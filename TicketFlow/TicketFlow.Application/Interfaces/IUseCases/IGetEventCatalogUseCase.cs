using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetEventCatalogUseCase
    {
        Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize);
    }
}
