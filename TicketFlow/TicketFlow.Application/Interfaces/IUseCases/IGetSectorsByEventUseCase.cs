using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetSectorsByEventUseCase
    {
        Task<IEnumerable<SectorResponse>> ExecuteAsync(int eventId);
    }
}