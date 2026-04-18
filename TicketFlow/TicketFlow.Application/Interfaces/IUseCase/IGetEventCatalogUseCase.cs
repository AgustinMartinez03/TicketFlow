using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetEventCatalogUseCase
    {
        // Devolvemos el objeto específico del catálogo
        Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize);
    }
}
