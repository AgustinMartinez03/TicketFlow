using Microsoft.AspNetCore.Mvc;
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

        // POST: api/v1/seats/{id}/reserve
        [HttpPost("{id}/reserve")]
        public async Task<IActionResult> ReserveSeat(Guid id)
        {
            try
            {
                var message = await _reserveUseCase.ExecuteAsync(id);
                return Ok(new { Message = message });
            }
            catch (Exception ex)
            {
                // Si la butaca no existe o ya está vendida, capturamos el error y devolvemos un 400 Bad Request
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}