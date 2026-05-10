using TicketFlow.Application.DTOs.Response;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface ILoginMapper
    {
        LoginResponse MapToLoginResponse(User user, string token);
    }
}