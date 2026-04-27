using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Exceptions;

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
            // 1. Validación de Entrada (Bad Request)
            if (userId <= 0)
            {
                throw new ExceptionBadRequest("El ID del usuario debe ser un número positivo.");
            }

            // 2. Traer los datos de la base de datos
            var results = await _query.GetReservationsByUserIdAsync(userId);

            // 3. Validación de Negocio (Not Found)
            if (results == null || !results.Any())
            {
                throw new ExceptionNotFound($"No se encontraron reservas para el usuario con ID {userId}.");
            }

            return results;
        }
    }
}
