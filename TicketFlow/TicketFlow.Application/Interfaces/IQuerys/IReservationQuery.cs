using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IReservationQuery
    {
        Task<List<UserReservationResponse>> GetReservationsByUserIdAsync(int userId);
    }
}
