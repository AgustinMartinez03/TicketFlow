using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SeatsController : ControllerBase
    {
        private readonly IReserveSeatUseCase _reserveUseCase;

        public SeatsController(IReserveSeatUseCase reserveUseCase)
        {
            _reserveUseCase = reserveUseCase;
        }

        // POST: api/v1/seats/reserve
        [HttpPost("reserve")]
        public async Task<IActionResult> ReserveSeat([FromBody] ReserveSeatRequest request)
        {
            try
            {
                var message = await _reserveUseCase.ExecuteAsync(request);
                // Aquí usamos 201 Created porque estamos creando una Reservation
                return StatusCode(201, new { Message = message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}