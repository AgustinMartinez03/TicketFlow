using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Command
{
    public class SeatCommand : ISeatCommand
    {
        private readonly AppDbContext _context;

        public SeatCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Seat?> GetSeatByIdAsync(Guid seatId)
        {
            // Usamos FindAsync porque es la forma más rápida de buscar por Primary Key
            return await _context.Seats.FindAsync(seatId);
        }

        public void UpdateSeat(Seat seat)
        {
            _context.Seats.Update(seat);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}