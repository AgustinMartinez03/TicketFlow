using Microsoft.EntityFrameworkCore; // 👈 NECESARIO PARA DbUpdateConcurrencyException
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class ReserveSeatUseCase : IReserveSeatUseCase
    {
        private readonly ISeatCommand _seatCommand;
        private readonly ISeatQuery _seatQuery;
        private readonly IUserQuery _userQuery;
        private readonly IReservationCommand _reservationCommand;
        private readonly IAuditLogCommand _auditLogCommand;

        public ReserveSeatUseCase(
            ISeatCommand seatCommand,
            ISeatQuery seatQuery,
            IUserQuery userQuery,
            IReservationCommand reservationCommand,
            IAuditLogCommand auditLogCommand)
        {
            _seatCommand = seatCommand;
            _seatQuery = seatQuery;
            _userQuery = userQuery;
            _reservationCommand = reservationCommand;
            _auditLogCommand = auditLogCommand;
        }

        public async Task<ReserveSeatResponse> ExecuteAsync(ReserveSeatRequest request)
        {
            if (request.UserId <= 0)
            {
                throw new ExceptionBadRequest("El ID del usuario debe ser un número positivo.");
            }

            if (request.SeatId == Guid.Empty)
            {
                throw new ExceptionBadRequest("El ID de la butaca es obligatorio.");
            }

            // 1. LEER LA BASE DE DATOS (Obtiene la butaca con su Version actual, ej: Version = 1)
            var seat = await _seatQuery.GetSeatByIdAsync(request.SeatId);

            if (seat == null)
            {
                throw new ExceptionNotFound("La butaca no existe.");
            }

            if (seat.Status != "Available")
            {
                throw new ExceptionConflict($"La butaca ya no está disponible. Estado: {seat.Status}");
            }

            var user = await _userQuery.GetUserByIdAsync(request.UserId);

            if (user == null)
            {
                throw new ExceptionNotFound("El usuario no existe.");
            }

            // 2. MODIFICAR EL ESTADO EN MEMORIA
            seat.Status = "Reserved";
            seat.Version++;
            _seatCommand.UpdateSeat(seat);

            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                SeatId = seat.Id,
                Status = "Pending", // Sugerencia de Tech Lead: "Pending" tiene más sentido inicial que "Confirmed" hasta que pague.
                ReservedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddMinutes(5) // Ajustado a la regla de negocio de los 5 minutos
            };
            _reservationCommand.InsertReservation(reservation);

            var auditLog = new AuditLog
            {
                UserId = request.UserId,
                Action = "RESERVE_SUCCESS",
                EntityType = "Seat",
                EntityId = seat.Id.ToString(),
                Details = $"Usuario {request.UserId} reservó exitosamente la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                CreatedAt = DateTime.UtcNow
            };
            _auditLogCommand.InsertAuditLog(auditLog);

            // 3. INTENTAR GUARDAR EN BASE DE DATOS (Acá ocurre la magia de la concurrencia)
            try
            {
                await _seatCommand.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // 🛡️ SI LLEGAMOS ACÁ: Alguien más compró la butaca milisegundos antes que nosotros.
                // TODO: Registrar intento fallido en AuditLog (Ver nota abajo)

                // 🛡️ 1. Limpiamos la memoria para que EF Core no intente guardar la basura de nuevo
                _seatCommand.DiscardChanges();

                // 🛡️ 2. Creamos el log de fallo
                var errorLog = new AuditLog
                {
                    UserId = request.UserId,
                    Action = "RESERVE_FAILED",
                    EntityType = "Seat",
                    EntityId = seat.Id.ToString(),
                    Details = $"Choque de concurrencia: Usuario {request.UserId} perdió la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                    CreatedAt = DateTime.UtcNow
                };

                // 🛡️ 3. Guardamos solo este log en la base de datos limpia
                _auditLogCommand.InsertAuditLog(errorLog);
                await _seatCommand.SaveChangesAsync();

                // 🛡️ 4. Explotamos con el 409 para el usuario
                throw new ExceptionConflict("¡Ups! Otro usuario acaba de ganar esta butaca. Por favor, selecciona otra.");
            }

            return new ReserveSeatResponse
            {
                ReservationId = reservation.Id,
                Message = $"Reserva exitosa. Tu Nro de Comprobante es {reservation.Id}"
            };
        }
    }
}