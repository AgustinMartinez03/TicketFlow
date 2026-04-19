using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISeatQuery
    {
        Task<IEnumerable<SeatResponse>> GetSeatsBySectorAsync(int sectorId);
    }
}