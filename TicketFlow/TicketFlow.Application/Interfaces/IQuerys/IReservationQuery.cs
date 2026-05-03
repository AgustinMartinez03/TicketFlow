using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IReservationQuery
    {
        Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
        Task<Reservation?> GetReservationByIdAsync(Guid id);
        // 👇 EL NUEVO CONTRATO PARA EL WORKER
        Task<IEnumerable<Reservation>> GetExpiredPendingReservationsAsync(DateTime referenceTime);
    }
}