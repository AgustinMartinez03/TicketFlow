using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Command
{
    public class EventCommand : IEventCommand
    {
        private readonly AppDbContext _context;

        public EventCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Event> InsertEventAsync(Event newEvent)
        {
            await _context.Events.AddAsync(newEvent);
            return newEvent;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}