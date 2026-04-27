using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Exceptions;

namespace TicketFlow.Application.UseCases
{
    public class GetSeatsBySectorUseCase : IGetSeatsBySectorUseCase
    {
        private readonly ISeatQuery _seatQuery;
        private readonly ISeatMapper _seatMapper;

        public GetSeatsBySectorUseCase(ISeatQuery seatQuery, ISeatMapper seatMapper)
        {
            _seatQuery = seatQuery;
            _seatMapper = seatMapper;
        }

        public async Task<IEnumerable<SeatResponse>> ExecuteAsync(int sectorId)
        {
            // 1. Validación de Entrada (Bad Request)
            if (sectorId <= 0)
            {
                throw new ExceptionBadRequest("El ID del sector debe ser un número positivo.");
            }

            // 2. Traer entidades
            var seats = await _seatQuery.GetSeatsBySectorAsync(sectorId);

            // 3. Validación de Negocio (Not Found)
            if (seats == null || !seats.Any())
            {
                throw new ExceptionNotFound($"No se encontraron butacas para el sector con ID {sectorId}.");
            }

            // 4. Mapear y devolver
            return _seatMapper.MapToSeatResponseList(seats);
        }
    }
}