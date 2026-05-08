using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using Microsoft.AspNetCore.Authorization;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class ReservationsController : ControllerBase
    {
        private readonly IReserveSeatUseCase _reserveUseCase;

        public ReservationsController(IReserveSeatUseCase reserveUseCase)
        {
            _reserveUseCase = reserveUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ReserveSeatResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ReserveSeat([FromBody] ReserveSeatRequest request)
        {
            var response = await _reserveUseCase.ExecuteAsync(request);
            return Created($"/api/v1/users/{request.UserId}/reservations", response);
        }
    }
}