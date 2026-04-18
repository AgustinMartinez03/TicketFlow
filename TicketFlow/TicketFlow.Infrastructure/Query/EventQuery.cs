using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
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

        public async Task<(IEnumerable<EventResponse> Events, int TotalRecords)> GetPaginatedEventsAsync(int pageNumber, int pageSize)
        {
            var query = _context.Events.AsNoTracking();

            var totalRecords = await query.CountAsync();

            var events = await query
                .OrderBy(e => e.EventDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                // PROYECTAMOS AL NUEVO EVENTRESPONSE
                .Select(e => new EventResponse
                {
                    Id = e.Id,
                    Name = e.Name,
                    EventDate = e.EventDate,
                    Venue = e.Venue,
                    Status = e.Status
                })
                .ToListAsync();

            return (events, totalRecords);
        }
    }
}
