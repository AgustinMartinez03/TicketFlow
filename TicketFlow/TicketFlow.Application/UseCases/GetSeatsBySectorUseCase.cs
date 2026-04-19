using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetSeatsBySectorUseCase : IGetSeatsBySectorUseCase
    {
        private readonly ISeatQuery _seatQuery;

        public GetSeatsBySectorUseCase(ISeatQuery seatQuery)
        {
            _seatQuery = seatQuery;
        }

        public async Task<IEnumerable<SeatResponse>> ExecuteAsync(int sectorId)
        {
            // Aquí podríamos agregar lógica si el sectorId es inválido (ej. <= 0)
            return await _seatQuery.GetSeatsBySectorAsync(sectorId);
        }
    }
}