using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class CreateEventUseCase
    {
        private readonly IEventCommand _eventCommand;

        public CreateEventUseCase(IEventCommand eventCommand)
        {
            _eventCommand = eventCommand;
        }

        public async Task<int> ExecuteAsync(CreateEventRequest request)
        {
            var newEvent = new Event
            {
                Name = request.Name,
                EventDate = request.EventDate,
                Venue = request.Venue,
                Status = "Active"
            };

            await _eventCommand.InsertEventAsync(newEvent);
            await _eventCommand.SaveChangesAsync();

            return newEvent.Id;
        }
    }
}