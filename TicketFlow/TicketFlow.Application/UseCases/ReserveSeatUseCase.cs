using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions; // Nuestras excepciones limpias
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

        // Quitamos IValidator del constructor
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
            // --- 1. VALIDACIONES DE ENTRADA (Reemplazando a FluentValidation) ---
            if (request.UserId <= 0)
            {
                throw new ExceptionBadRequest("El ID del usuario debe ser un número positivo.");
            }

            if (request.SeatId == Guid.Empty)
            {
                throw new ExceptionBadRequest("El ID de la butaca es obligatorio.");
            }

            // --- 2. VALIDAR BUTACA (Not Found y Conflict) ---
            var seat = await _seatQuery.GetSeatByIdAsync(request.SeatId);

            if (seat == null)
            {
                throw new ExceptionNotFound("La butaca no existe.");
            }

            if (seat.Status != "Available")
            {
                throw new ExceptionConflict($"La butaca ya no está disponible. Estado: {seat.Status}");
            }

            // --- 2. VALIDAR USUARIO(Not Found) ---
            var user = await _userQuery.GetUserByIdAsync(request.UserId);

            if (user == null)
            {
                throw new ExceptionNotFound("El usuario no existe.");
            }


            // --- 3. MODIFICAR BUTACA ---
            seat.Status = "Reserved";
            _seatCommand.UpdateSeat(seat); // Tu método original

            // --- 4. CREAR RESERVA ---
            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                SeatId = seat.Id,
                Status = "Confirmed",
                ReservedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddHours(24) // Tu regla de negocio
            };
            _reservationCommand.InsertReservation(reservation); // Tu método original

            // --- 5. CREAR LOG DE AUDITORÍA ---
            var auditLog = new AuditLog
            {
                UserId = request.UserId,
                Action = "RESERVE",
                EntityType = "Seat",
                EntityId = seat.Id.ToString(),
                Details = $"Usuario {request.UserId} reservó la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                CreatedAt = DateTime.UtcNow
            };
            _auditLogCommand.InsertAuditLog(auditLog); // Tu método original

            // --- 6. GUARDAR TODO ---
            await _seatCommand.SaveChangesAsync(); // Tu método original

            // --- 7. DEVOLVER EL DTO ---
            return new ReserveSeatResponse
            {
                ReservationId = reservation.Id,
                Message = $"Reserva exitosa. Tu Nro de Comprobante es {reservation.Id}"
            };
        }
    }
}