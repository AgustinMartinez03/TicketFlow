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
            if (sectorId <= 0)
            {
                throw new ExceptionBadRequest("El ID del sector debe ser un número positivo.");
            }

            var seats = await _seatQuery.GetSeatsBySectorAsync(sectorId);

            if (seats == null || !seats.Any())
            {
                throw new ExceptionNotFound($"No se encontraron butacas para el sector con ID {sectorId}.");
            }

            return _seatMapper.MapToSeatResponseList(seats);
        }
    }
}