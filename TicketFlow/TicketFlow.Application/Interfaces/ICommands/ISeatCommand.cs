using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface ISeatCommand
    {
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
        void UpdateSeat(Seat seat);
        Task SaveChangesAsync();
    }
}