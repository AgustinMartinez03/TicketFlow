using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface ICreateEventUseCase
    {
        Task<CreateEventResponse> ExecuteAsync(CreateEventRequest request);
    }
}
