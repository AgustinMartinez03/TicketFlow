using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface IAuditLogCommand
    {
        void InsertAuditLog(AuditLog log);
    }
    /* Nota: No les ponemos SaveChangesAsync a estas interfaces porque usaremos 
     * el del ISeatCommand para guardar todo en una sola transacción*/
}