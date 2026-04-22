using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
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

        public async Task<List<SectorResponse>> GetSectorsByEventIdAsync(int eventId)
        {
            return await _context.Sectors
                .AsNoTracking() // Clave para lecturas ultrarrápidas
                .Where(s => s.EventId == eventId)
                .Select(s => new SectorResponse
                {
                    Id = s.Id,
                    Name = s.Name,
                    Price = s.Price,
                    Capacity = s.Capacity
                })
                .ToListAsync();
        }
    }
}