using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetEventCatalogUseCase : IGetEventCatalogUseCase
    {
        private readonly IEventQuery _eventQuery;
        private readonly IEventMapper _eventMapper; // Inyectamos el mapper

        public GetEventCatalogUseCase(IEventQuery eventQuery, IEventMapper eventMapper)
        {
            _eventQuery = eventQuery;
            _eventMapper = eventMapper;
        }

        public async Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize)
        {
            var (events, totalRecords) = await _eventQuery.GetPaginatedEventsAsync(pageNumber, pageSize);

            // Usamos el mapper para convertir la lista de entidades a DTOs
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