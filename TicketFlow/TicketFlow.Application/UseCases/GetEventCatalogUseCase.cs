using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Exceptions;

namespace TicketFlow.Application.UseCases
{
    public class GetEventCatalogUseCase : IGetEventCatalogUseCase
    {
        private readonly IEventQuery _eventQuery;
        private readonly IEventMapper _eventMapper;

        public GetEventCatalogUseCase(IEventQuery eventQuery, IEventMapper eventMapper)
        {
            _eventQuery = eventQuery;
            _eventMapper = eventMapper;
        }

        public async Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
            {
                throw new ExceptionBadRequest("El número de página debe ser mayor a 0.");
            }

            if (pageSize < 1)
            {
                throw new ExceptionBadRequest("El tamaño de la página debe ser mayor a 0.");
            }

            if (pageSize > 100)
            {
                throw new ExceptionBadRequest("El tamaño máximo de página permitido es 100.");
            }

            var (events, totalRecords) = await _eventQuery.GetPaginatedEventsAsync(pageNumber, pageSize);

            return new EventCatalogResponse
            {
                Events = _eventMapper.MapToEventResponse(events),
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}