using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IGetUserReservationsUseCase _useCase;

        public UsersController(IGetUserReservationsUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpGet("{id}/reservations")]
        public async Task<IActionResult> GetUserReservations(int id)
        {
            var results = await _useCase.ExecuteAsync(id);
            return Ok(results);
        }
    }
}