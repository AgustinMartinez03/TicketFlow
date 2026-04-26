using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface IEventMapper
    {
        Event CreateEvent(CreateEventRequest request);
        List<EventResponse> MapToEventResponse(IEnumerable<Event> eventEntity);
    }
}
