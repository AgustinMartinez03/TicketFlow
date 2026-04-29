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

        [HttpPost]
        [ProducesResponseType(typeof(CreateEventResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            try
            {
                var result = await _createEventUseCase.ExecuteAsync(request);

                return Created($"/api/v1/events/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(EventCatalogResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEvents([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var response = await _getCatalogUseCase.ExecuteAsync(pageNumber, pageSize);
                return Ok(response);
            }
            catch (ExceptionBadRequest ex)
            {
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }

        [HttpGet("{id}/sectors")]
        [ProducesResponseType(typeof(IEnumerable<SectorResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetSectors(int id)
        {
            try
            {
                var sectors = await _getSectorsUseCase.ExecuteAsync(id);
                return Ok(sectors);
            }
            catch (ExceptionNotFound ex)
            {
                return NotFound(new ApiError { Message = ex.Message });
            }
            catch (ExceptionBadRequest ex)
            {
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }
    }
}