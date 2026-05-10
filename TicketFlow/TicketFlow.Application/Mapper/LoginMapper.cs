using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Mapper
{
    public class LoginMapper : ILoginMapper
    {
        public LoginResponse MapToLoginResponse(User user, string token)
        {
            return new LoginResponse
            {
                Token = token,
                Name = user.Name,
                Role = user.Role
            };
        }
    }
}