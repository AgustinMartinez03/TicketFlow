using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Querys
{
    public class EventQuery : IEventQuery
    {
        private readonly AppDbContext _context;

        public EventQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<(IEnumerable<Event> Events, int TotalRecords)> GetPaginatedEventsAsync(int pageNumber, int pageSize)
        {
            var query = _context.Events.AsNoTracking();
            var totalRecords = await query.CountAsync();

            var events = await query
                .OrderBy(e => e.EventDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (events, totalRecords);
        }
    }
}
