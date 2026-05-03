using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class CancelExpiredReservationsUseCase : ICancelExpiredReservationsUseCase
    {
        private readonly IReservationQuery _reservationQuery;
        private readonly ISeatQuery _seatQuery;
        private readonly ISeatCommand _seatCommand;
        private readonly IReservationCommand _reservationCommand;
        private readonly IAuditLogCommand _auditLogCommand;

        public CancelExpiredReservationsUseCase(
            IReservationQuery reservationQuery,
            ISeatQuery seatQuery,
            ISeatCommand seatCommand,
            IReservationCommand reservationCommand,
            IAuditLogCommand auditLogCommand)
        {
            _reservationQuery = reservationQuery;
            _seatQuery = seatQuery;
            _seatCommand = seatCommand;
            _reservationCommand = reservationCommand;
            _auditLogCommand = auditLogCommand;
        }

        public async Task ExecuteAsync()
        {
            // 1. Usamos la Query purificada
            var expiredReservations = await _reservationQuery.GetExpiredPendingReservationsAsync(DateTime.UtcNow);

            if (!expiredReservations.Any())
                return; // No hay nada que limpiar

            foreach (var reservation in expiredReservations)
            {
                await _seatCommand.BeginTransactionAsync();

                try
                {
                    reservation.Status = "Cancelled";
                    _reservationCommand.UpdateReservation(reservation);

                    // 2. Usamos la Query de Seat en lugar del DbContext directo
                    var seat = await _seatQuery.GetSeatByIdAsync(reservation.SeatId);
                    if (seat != null)
                    {
                        seat.Status = "Available";
                        seat.Version++;
                        _seatCommand.UpdateSeat(seat);
                    }

                    var auditLog = new AuditLog
                    {
                        UserId = reservation.UserId,
                        Action = "RESERVATION_EXPIRED",
                        EntityType = "Reservation",
                        EntityId = reservation.Id.ToString(),
                        Details = $"Reserva expirada por falta de pago. Butaca {seat?.RowIdentifier}-{seat?.SeatNumber} liberada.",
                        CreatedAt = DateTime.UtcNow
                    };
                    _auditLogCommand.InsertAuditLog(auditLog);

                    await _seatCommand.SaveChangesAsync();
                    await _seatCommand.CommitTransactionAsync();
                }
                catch (Exception)
                {
                    await _seatCommand.RollbackTransactionAsync();
                    _seatCommand.DiscardChanges(); // Limpiamos la memoria por si acaso
                }
            }
        }
    }
}