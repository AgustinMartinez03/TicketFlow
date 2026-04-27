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

        public async Task<Seat?> GetSeatByIdAsync(Guid seatId)
        {
            // Usamos FindAsync porque es la forma más rápida de buscar por Primary Key
            return await _context.Seats.FindAsync(seatId);
        }
    }
}