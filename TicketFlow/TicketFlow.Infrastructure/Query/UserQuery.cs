using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Query
{
    public class UserQuery : IUserQuery
    {
        private readonly AppDbContext _context;

        public UserQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }
    }
}
