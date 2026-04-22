using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISectorQuery
    {
        Task<List<SectorResponse>> GetSectorsByEventIdAsync(int eventId);
    }
}