using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.DTOs.Response;
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

        public async Task<IEnumerable<SeatResponse>> GetSeatsBySectorAsync(int sectorId)
        {
            return await _context.Seats
                .AsNoTracking() // Vital para lectura rápida
                .Where(s => s.SectorId == sectorId)
                .OrderBy(s => s.RowIdentifier)
                .ThenBy(s => s.SeatNumber) // Ordenamos por fila A,B,C y luego asiento 1,2,3
                .Select(s => new SeatResponse
                {
                    Id = s.Id,
                    RowIdentifier = s.RowIdentifier,
                    SeatNumber = s.SeatNumber,
                    Status = s.Status
                })
                .ToListAsync();
        }
    }
}