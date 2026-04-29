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
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> ReserveSeat([FromBody] ReserveSeatRequest request)
        {
            try
            {
                var response = await _reserveUseCase.ExecuteAsync(request);

                return Created($"/api/v1/users/{request.UserId}/reservations", response);
            }
            catch (ExceptionBadRequest ex)
            {
                return BadRequest(new ApiError { Message = ex.Message });
            }
            catch (ExceptionNotFound ex)
            {
                return NotFound(new ApiError { Message = ex.Message });
            }
            catch (ExceptionConflict ex)
            {
                return Conflict(new ApiError { Message = ex.Message });
            }
        }
    }
}