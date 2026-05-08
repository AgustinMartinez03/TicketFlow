using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Response;
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
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserReservations(int id)
        {
            var results = await _getUserReservationUseCase.ExecuteAsync(id);
            return Ok(results);
        }
    }
}