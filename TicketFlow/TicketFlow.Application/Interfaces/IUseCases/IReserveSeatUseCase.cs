using TicketFlow.Application.DTOs.Request;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IReserveSeatUseCase
    {
        Task<string> ExecuteAsync(ReserveSeatRequest request);
    }
}