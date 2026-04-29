using Microsoft.EntityFrameworkCore;
using TicketFlow.Domain.Entities; // Cambiamos el DTO por la entidad
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Querys
{
    public class ReservationQuery : IReservationQuery
    {
        private readonly AppDbContext _context;

        public ReservationQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.Seat)
                    .ThenInclude(s => s.Sector)
                        .ThenInclude(sec => sec.Event)
                .Where(r => r.UserId == userId)
                .ToListAsync();
        }

        public async Task<Seat?> GetSeatByIdAsync(Guid seatId)
        {
            return await _context.Seats.FirstOrDefaultAsync(s => s.Id == seatId);
        }
    }
}