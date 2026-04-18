using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.IUseCase;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ICreateEventUseCase _createUseCase;
        private readonly IGetEventCatalogUseCase _getCatalogUseCase;

        public EventsController(ICreateEventUseCase createUseCase, IGetEventCatalogUseCase getCatalogUseCase)
        {
            _createUseCase = createUseCase;
            _getCatalogUseCase = getCatalogUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            var eventId = await _createUseCase.ExecuteAsync(request);
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
    }
}