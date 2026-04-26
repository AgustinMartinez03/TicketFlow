using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetSectorsByEventUseCase : IGetSectorsByEventUseCase
    {
        private readonly ISectorQuery _sectorQuery;
        private readonly ISectorMapper _sectorMapper; // 1. Inyectamos el mapper

        public GetSectorsByEventUseCase(ISectorQuery sectorQuery, ISectorMapper sectorMapper)
        {
            _sectorQuery = sectorQuery;
            _sectorMapper = sectorMapper;
        }

        public async Task<IEnumerable<SectorResponse>> ExecuteAsync(int eventId)
        {
            // 2. Obtenemos las entidades del Query
            var sectors = await _sectorQuery.GetSectorsByEventAsync(eventId);

            // 3. Las transformamos usando el mapper
            return _sectorMapper.MapToSectorResponseList(sectors);
        }
    }
}