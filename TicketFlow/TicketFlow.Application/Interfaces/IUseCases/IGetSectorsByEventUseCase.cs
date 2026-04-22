using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetSectorsByEventUseCase
    {
        Task<List<SectorResponse>> ExecuteAsync(int eventId);
    }
}