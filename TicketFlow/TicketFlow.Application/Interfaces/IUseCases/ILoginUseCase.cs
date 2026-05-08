using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface ILoginUseCase
    {
        Task<LoginResponse> ExecuteAsync(LoginRequest request);
    }
}
