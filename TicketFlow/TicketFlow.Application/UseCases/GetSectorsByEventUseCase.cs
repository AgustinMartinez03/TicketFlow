using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Exceptions;


namespace TicketFlow.Application.UseCases
{
    public class GetSectorsByEventUseCase : IGetSectorsByEventUseCase
    {
        private readonly ISectorQuery _sectorQuery;
        private readonly ISectorMapper _sectorMapper;

        public GetSectorsByEventUseCase(ISectorQuery sectorQuery, ISectorMapper sectorMapper)
        {
            _sectorQuery = sectorQuery;
            _sectorMapper = sectorMapper;
        }

        public async Task<IEnumerable<SectorResponse>> ExecuteAsync(int eventId)
        {
            if (eventId <= 0)
            {
                throw new ExceptionBadRequest("El ID del evento debe ser un número positivo.");
            }

            var sectors = await _sectorQuery.GetSectorsByEventAsync(eventId);

            if (sectors == null || !sectors.Any())
            {
                throw new ExceptionNotFound($"No se encontraron sectores para el evento con ID {eventId}.");
            }

            return _sectorMapper.MapToSectorResponseList(sectors);
        }
    }
}