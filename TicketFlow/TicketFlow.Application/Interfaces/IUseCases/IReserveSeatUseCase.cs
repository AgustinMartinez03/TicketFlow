using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IReserveSeatUseCase
    {
        Task<ReserveSeatResponse> ExecuteAsync(ReserveSeatRequest request);
    }
}