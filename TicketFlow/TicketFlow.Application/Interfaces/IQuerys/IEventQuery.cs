using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IEventQuery
    {
        // Cambiamos EventDto por EventResponse
        Task<(IEnumerable<EventResponse> Events, int TotalRecords)> GetPaginatedEventsAsync(int pageNumber, int pageSize);
    }
}
