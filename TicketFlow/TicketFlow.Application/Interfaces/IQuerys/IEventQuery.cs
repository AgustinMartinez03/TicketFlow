using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IEventQuery
    {
        Task<(IEnumerable<Event> Events, int TotalRecords)> GetPaginatedEventsAsync(int pageNumber, int pageSize);
        Task<bool> ExistsEventAtVenueAndDateAsync(string venue, DateTime eventDate);
    }
}