using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Query
{
    public class SectorQuery : ISectorQuery
    {
        private readonly AppDbContext _context;

        public SectorQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sector>> GetSectorsByEventAsync(int eventId)
        {
            return await _context.Sectors
                .AsNoTracking()
                .Where(s => s.EventId == eventId)
                .ToListAsync();
        }
    }
}