using Aplication.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.IUseCases;

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

        [HttpGet("{id}/seats")]
        [ProducesResponseType(typeof(IEnumerable<SeatResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetSeatsBySector(int id)
        {
            try
            {
                var seats = await _getSeatsBySectorUseCase.ExecuteAsync(id);
                return Ok(seats);
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