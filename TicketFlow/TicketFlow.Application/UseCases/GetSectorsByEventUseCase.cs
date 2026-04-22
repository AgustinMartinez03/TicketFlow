using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetSectorsByEventUseCase : IGetSectorsByEventUseCase
    {
        private readonly ISectorQuery _sectorQuery;

        public GetSectorsByEventUseCase(ISectorQuery sectorQuery)
        {
            _sectorQuery = sectorQuery;
        }

        public async Task<List<SectorResponse>> ExecuteAsync(int eventId)
        {
            return await _sectorQuery.GetSectorsByEventIdAsync(eventId);
        }
    }
}