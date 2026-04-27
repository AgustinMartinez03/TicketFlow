using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response; // Importamos los DTOs de respuesta

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface ICreateEventUseCase
    {
        // Ahora devolvemos una clase de respuesta, no un simple int
        Task<CreateEventResponse> ExecuteAsync(CreateEventRequest request);
    }
}
