using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface IAuditLogCommand
    {
        void InsertAuditLog(AuditLog log);
        Task SaveChangesAsync();
    }
    // Nota de Diseño: Se omite el método SaveChangesAsync en el Caso de Uso ReserveSeatUseCase.
    // La persistencia de la transacción completa (Reserva + Butaca + Auditoría) 
    // es coordinada por el Caso de Uso para garantizar atomicidad.
}