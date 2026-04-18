using TicketFlow.Application.DTOs.Request;

namespace TicketFlow.Application.Interfaces.IUseCase
{
    public interface ICreateEventUseCase
    {
        Task<int> ExecuteAsync(CreateEventRequest request);
    }
}
