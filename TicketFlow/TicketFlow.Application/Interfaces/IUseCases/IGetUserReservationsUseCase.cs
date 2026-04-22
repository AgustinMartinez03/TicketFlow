using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IGetUserReservationsUseCase
    {
        Task<List<UserReservationResponse>> ExecuteAsync(int userId);
    }
}