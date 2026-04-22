using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.DTOs.Response;
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

        public async Task<List<UserReservationResponse>> GetReservationsByUserIdAsync(int userId)
        {
            return await _context.Reservations
                .AsNoTracking() // Lectura rápida
                .Include(r => r.Seat) // Unimos con Seat
                    .ThenInclude(s => s.Sector) // Desde Seat, unimos con Sector
                        .ThenInclude(sec => sec.Event) // Desde Sector, unimos con Event
                .Where(r => r.UserId == userId)
                .Select(r => new UserReservationResponse
                {
                    ReservationId = r.Id,
                    EventName = r.Seat.Sector.Event.Name,
                    EventDate = r.Seat.Sector.Event.EventDate,
                    Venue = r.Seat.Sector.Event.Venue,
                    SectorName = r.Seat.Sector.Name,
                    SeatDetails = $"Fila {r.Seat.RowIdentifier} - Asiento {r.Seat.SeatNumber}",
                    Status = r.Status
                })
                .ToListAsync();
        }
    }
}