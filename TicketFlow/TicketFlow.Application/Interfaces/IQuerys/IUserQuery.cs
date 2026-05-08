using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IUserQuery
    {
        Task<User?> GetUserByIdAsync(int userId);

        Task<User?> GetUserByEmailAsync(string email);
    }
}
