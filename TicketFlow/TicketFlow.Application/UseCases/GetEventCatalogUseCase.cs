using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class GetEventCatalogUseCase : IGetEventCatalogUseCase
    {
        private readonly IEventQuery _eventQuery;

        public GetEventCatalogUseCase(IEventQuery eventQuery)
        {
            _eventQuery = eventQuery;
        }

        public async Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;
            if (pageSize > 50) pageSize = 50;

            var result = await _eventQuery.GetPaginatedEventsAsync(pageNumber, pageSize);

            // Armamos la respuesta específica
            return new EventCatalogResponse
            {
                Events = result.Events,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = result.TotalRecords
            };
        }
    }
}