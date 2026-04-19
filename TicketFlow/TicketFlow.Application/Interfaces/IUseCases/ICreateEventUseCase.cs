using TicketFlow.Application.DTOs.Request;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface ICreateEventUseCase
    {
        Task<int> ExecuteAsync(CreateEventRequest request);
    }
}
