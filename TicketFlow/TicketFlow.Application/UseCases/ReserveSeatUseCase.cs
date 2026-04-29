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
            _seatCommand.UpdateSeat(seat);

            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                SeatId = seat.Id,
                Status = "Confirmed",
                ReservedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddHours(24)
            };
            _reservationCommand.InsertReservation(reservation);

            var auditLog = new AuditLog
            {
                UserId = request.UserId,
                Action = "RESERVE",
                EntityType = "Seat",
                EntityId = seat.Id.ToString(),
                Details = $"Usuario {request.UserId} reservó la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                CreatedAt = DateTime.UtcNow
            };
            _auditLogCommand.InsertAuditLog(auditLog);

            await _seatCommand.SaveChangesAsync();

            return new ReserveSeatResponse
            {
                ReservationId = reservation.Id,
                Message = $"Reserva exitosa. Tu Nro de Comprobante es {reservation.Id}"
            };
        }
    }
}