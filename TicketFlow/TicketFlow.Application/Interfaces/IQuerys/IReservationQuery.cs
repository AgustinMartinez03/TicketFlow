using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IReservationQuery
    {
        Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
    }
}