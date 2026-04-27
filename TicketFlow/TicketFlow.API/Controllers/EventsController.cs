using Aplication.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
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

        // POST: api/v1/events
        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            var eventId = await _createEventUseCase.ExecuteAsync(request);
            // Retornamos un objeto anónimo específico o simplemente el ID, ya no usamos el GenericResponse
            return CreatedAtAction(nameof(GetEvents), new { id = eventId }, new { Id = eventId, Message = "Evento creado exitosamente" });
        }

        // GET: api/v1/events
        [HttpGet]
        [ProducesResponseType(typeof(EventCatalogResponse), StatusCodes.Status200OK)] // Especificamos el tipo de respuesta esperado
        public async Task<IActionResult> GetEvents([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            // response ahora es de tipo EventCatalogResponse
            var response = await _getCatalogUseCase.ExecuteAsync(pageNumber, pageSize);
            return Ok(response);
        }

        // GET: api/v1/events/{id}/sectors
        [HttpGet("{id}/sectors")]
        [ProducesResponseType(typeof(IEnumerable<SectorResponse>), StatusCodes.Status200OK)] // Tip: siempre usa IEnumerable o List en el type
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetSectors(int id)
        {
            try
            {
                // El controlador llama a ciegas
                var sectors = await _getSectorsUseCase.ExecuteAsync(id);
                return Ok(sectors);
            }
            catch (ExceptionNotFound ex)
            {
                // Si el UseCase gritó, lo atrapamos y devolvemos el 404 estandarizado
                return NotFound(new ApiError { Message = ex.Message });
            }
            catch (ExceptionBadRequest ex)
            {
                // Atrapamos el error de validación y devolvemos 400
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }
    }
}