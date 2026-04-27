using Aplication.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.UseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SectorsController : ControllerBase
    {
        private readonly IGetSeatsBySectorUseCase _getSeatsBySectorUseCase;

        public SectorsController(IGetSeatsBySectorUseCase getSeatsUseCase)
        {
            _getSeatsBySectorUseCase = getSeatsUseCase;
        }

        // GET: api/v1/sectors/{sectorId}/seats
        [HttpGet("{id}/seats")]
        [ProducesResponseType(typeof(IEnumerable<SeatResponse>), StatusCodes.Status200OK)] // <- Corregido a IEnumerable
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]            // <- Documentado
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]          // <- Documentado
        public async Task<IActionResult> GetSeatsBySector(int id)
        {
            try
            {
                // El controlador ya no piensa, solo ejecuta
                var seats = await _getSeatsBySectorUseCase.ExecuteAsync(id);
                return Ok(seats);
            }
            catch (ExceptionNotFound ex)
            {
                // Atrapa el 404
                return NotFound(new ApiError { Message = ex.Message });
            }
            catch (ExceptionBadRequest ex)
            {
                // Atrapa el 400
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }
    }
}