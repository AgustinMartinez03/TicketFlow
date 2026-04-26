using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IUseCases;

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
            // 2. Traer entidades
            var seats = await _seatQuery.GetSeatsBySectorAsync(sectorId);

            // 3. Mapear y devolver
            return _seatMapper.MapToSeatResponseList(seats);
        }
    }
}