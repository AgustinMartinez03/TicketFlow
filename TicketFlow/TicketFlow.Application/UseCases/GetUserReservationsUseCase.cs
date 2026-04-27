using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IMapper; // Inyectar mapper
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Exceptions;

namespace TicketFlow.Application.UseCases
{
    public class GetUserReservationsUseCase : IGetUserReservationsUseCase
    {
        private readonly IReservationQuery _query;
        private readonly IReservationMapper _mapper; // Agregamos el mapper

        public GetUserReservationsUseCase(IReservationQuery query, IReservationMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<UserReservationResponse>> ExecuteAsync(int userId)
        {
            // 1. Validación
            if (userId <= 0)
                throw new ExceptionBadRequest("El ID del usuario debe ser un número positivo.");

            // 2. Traer entidades de DB
            var reservations = await _query.GetReservationsByUserIdAsync(userId);

            // 3. Validación de Negocio
            if (reservations == null || !reservations.Any())
                throw new ExceptionNotFound($"No se encontraron reservas para el usuario con ID {userId}.");

            // 4. Mapear y devolver
            return _mapper.MapToUserReservationResponseList(reservations);
        }
    }
}