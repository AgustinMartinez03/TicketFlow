using Microsoft.EntityFrameworkCore;
using TicketFlow.Domain.Entities;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Querys
{
    public class SeatQuery : ISeatQuery
    {
        private readonly AppDbContext _context;

        public SeatQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Seat>> GetSeatsBySectorAsync(int sectorId)
        {
            return await _context.Seats
                .AsNoTracking()
                .Where(s => s.SectorId == sectorId)
                .ToListAsync(); // Devolvemos la entidad sin mapear
        }
    }
}