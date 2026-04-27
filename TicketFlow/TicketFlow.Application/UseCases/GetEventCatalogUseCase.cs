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
        private readonly IEventMapper _eventMapper; // Inyectamos el mapper

        public GetEventCatalogUseCase(IEventQuery eventQuery, IEventMapper eventMapper)
        {
            _eventQuery = eventQuery;
            _eventMapper = eventMapper;
        }

        public async Task<EventCatalogResponse> ExecuteAsync(int pageNumber, int pageSize)
        {
            // 1. Validaciones de Entrada (Bad Request)
            if (pageNumber < 1)
            {
                throw new ExceptionBadRequest("El número de página debe ser mayor a 0.");
            }

            if (pageSize < 1)
            {
                throw new ExceptionBadRequest("El tamaño de la página debe ser mayor a 0.");
            }

            if (pageSize > 100) // Buena práctica de Tech Lead: evitar que pidan un millón de registros y tiren el servidor
            {
                throw new ExceptionBadRequest("El tamaño máximo de página permitido es 100.");
            }

            // 2. Ejecutar la consulta
            var (events, totalRecords) = await _eventQuery.GetPaginatedEventsAsync(pageNumber, pageSize);

            // 3. Mapear y devolver (Si events está vacío, devuelve una lista vacía, lo cual está perfecto para un 200 OK)
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