using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Interfaces.IMapper;
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
        private readonly IReservationMapper _reservationMapper;

        public ReserveSeatUseCase(
            ISeatCommand seatCommand,
            ISeatQuery seatQuery,
            IUserQuery userQuery,
            IReservationCommand reservationCommand,
            IAuditLogCommand auditLogCommand,
            IReservationMapper reservationMapper)
        {
            _seatCommand = seatCommand;
            _seatQuery = seatQuery;
            _userQuery = userQuery;
            _reservationCommand = reservationCommand;
            _auditLogCommand = auditLogCommand;
            _reservationMapper = reservationMapper;
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

            seat.Status = "Reserved";
            seat.Version++;
            _seatCommand.UpdateSeat(seat);

            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                SeatId = seat.Id,
                Status = "Pending",
                ReservedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddMinutes(5)
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

            try
            {
                await _seatCommand.SaveChangesAsync();
            }
            catch (ExceptionConcurrency)
            {
                _seatCommand.DiscardChanges();

                var errorLog = new AuditLog
                {
                    UserId = request.UserId,
                    Action = "RESERVE_FAILED",
                    EntityType = "Seat",
                    EntityId = seat.Id.ToString(),
                    Details = $"Choque de concurrencia: Usuario {request.UserId} perdió la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                    CreatedAt = DateTime.UtcNow
                };

                _auditLogCommand.InsertAuditLog(errorLog);
                await _seatCommand.SaveChangesAsync();

                throw new ExceptionConflict("¡Ups! Otro usuario acaba de ganar esta butaca. Por favor, selecciona otra.");
            }

            return _reservationMapper.MapToReserveSeatResponse(reservation, $"Reserva exitosa. Tu Nro de Comprobante es {reservation.Id}");
        }
    }
}