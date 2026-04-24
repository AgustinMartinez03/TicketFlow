using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SectorsController : ControllerBase
    {
        private readonly IGetSeatsBySectorUseCase _getSeatsUseCase;

        public SectorsController(IGetSeatsBySectorUseCase getSeatsUseCase)
        {
            _getSeatsUseCase = getSeatsUseCase;
        }

        // GET: api/v1/sectors/{sectorId}/seats
        [HttpGet("{sectorId}/seats")]
        [ProducesResponseType(typeof(SeatResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> GetSeatsBySector(int sectorId)
        {
            var seats = await _getSeatsUseCase.ExecuteAsync(sectorId);

            if (!seats.Any())
            {
                return NotFound(new { Message = $"No se encontraron butacas para el sector con ID {sectorId}" });
            }

            return Ok(seats);
        }
    }
}