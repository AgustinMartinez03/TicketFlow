using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetSeatsBySectorUseCase
    {
        Task<IEnumerable<SeatResponse>> ExecuteAsync(int sectorId);
    }
}