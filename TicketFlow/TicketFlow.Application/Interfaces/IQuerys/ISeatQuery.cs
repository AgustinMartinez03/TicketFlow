using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISeatQuery
    {
        Task<IEnumerable<Seat>> GetSeatsBySectorAsync(int sectorId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
    }
}