using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ICreateEventUseCase _createEventUseCase;
        private readonly IGetEventCatalogUseCase _getCatalogUseCase;
        private readonly IGetSectorsByEventUseCase _getSectorsUseCase;

        public EventsController(
            IGetEventCatalogUseCase getCatalogUseCase,
            ICreateEventUseCase createEventUseCase,
            IGetSectorsByEventUseCase getSectorsUseCase)
        {
            _getCatalogUseCase = getCatalogUseCase;
            _createEventUseCase = createEventUseCase;
            _getSectorsUseCase = getSectorsUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            var eventId = await _createEventUseCase.ExecuteAsync(request);
            // Retornamos un objeto anónimo específico o simplemente el ID, ya no usamos el GenericResponse
            return CreatedAtAction(nameof(GetEvents), new { id = eventId }, new { Id = eventId, Message = "Evento creado exitosamente" });
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            // response ahora es de tipo EventCatalogResponse
            var response = await _getCatalogUseCase.ExecuteAsync(pageNumber, pageSize);
            return Ok(response);
        }

        [HttpGet("{id}/sectors")]
        public async Task<IActionResult> GetSectors(int id)
        {
            var sectors = await _getSectorsUseCase.ExecuteAsync(id);

            // Buena práctica: Si la lista viene vacía, el evento no existe o no tiene sectores
            if (sectors == null || !sectors.Any())
            {
                return NotFound(new { Message = $"No se encontraron sectores para el evento con ID {id}." });
            }

            return Ok(sectors);
        }
    }
}