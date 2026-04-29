using Aplication.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IGetUserReservationsUseCase _getUserReservationUseCase;

        public UsersController(IGetUserReservationsUseCase useCase)
        {
            _getUserReservationUseCase = useCase;
        }

        [HttpGet("{id}/reservations")]
        [ProducesResponseType(typeof(List<UserReservationResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUserReservations(int id)
        {
            try
            {
                var results = await _getUserReservationUseCase.ExecuteAsync(id);
                return Ok(results);
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