using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Command
{
    public class AuditLogCommand : IAuditLogCommand
    {
        private readonly AppDbContext _context;

        public AuditLogCommand(AppDbContext context)
        {
            _context = context;
        }

        public void InsertAuditLog(AuditLog log)
        {
            _context.AuditLogs.Add(log);
        }
    }
}