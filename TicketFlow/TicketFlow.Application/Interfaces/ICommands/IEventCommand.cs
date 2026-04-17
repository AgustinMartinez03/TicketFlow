using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface IEventCommand
    {
        Task<Event> InsertEventAsync(Event newEvent);
        Task SaveChangesAsync();
    }
}