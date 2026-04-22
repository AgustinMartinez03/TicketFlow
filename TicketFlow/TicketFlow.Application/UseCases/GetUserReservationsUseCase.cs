using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetUserReservationsUseCase : IGetUserReservationsUseCase
    {
        private readonly IReservationQuery _query;

        public GetUserReservationsUseCase(IReservationQuery query)
        {
            _query = query;
        }

        public async Task<List<UserReservationResponse>> ExecuteAsync(int userId)
        {
            return await _query.GetReservationsByUserIdAsync(userId);
        }
    }
}
