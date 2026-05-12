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
    public class PaymentsController : ControllerBase
    {
        private readonly IPayReservationUseCase _payReservationUseCase;

        public PaymentsController(IPayReservationUseCase payReservationUseCase)
        {
            _payReservationUseCase = payReservationUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PayReservationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ProcessPayment([FromBody] PayReservationRequest request)
        {
            var response = await _payReservationUseCase.ExecuteAsync(request);
            return Ok(response);
        }
    }
}