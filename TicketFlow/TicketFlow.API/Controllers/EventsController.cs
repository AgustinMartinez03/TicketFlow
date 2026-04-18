using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.UseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly CreateEventUseCase _useCase;

        public EventsController(CreateEventUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            var eventId = await _useCase.ExecuteAsync(request);
            return CreatedAtAction(nameof(CreateEvent), new { id = eventId }, new { Id = eventId, Message = "Evento creado" });
        }
    }
}