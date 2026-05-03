using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface ISeatCommand
    {
        void UpdateSeat(Seat seat);
        Task SaveChangesAsync();
        void DiscardChanges();

        // 👇 NUEVOS MÉTODOS PARA TRANSACCIONES
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}