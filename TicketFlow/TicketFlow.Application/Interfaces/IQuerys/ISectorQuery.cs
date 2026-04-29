using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISectorQuery
    {
        Task<IEnumerable<Sector>> GetSectorsByEventAsync(int eventId);
    }
}