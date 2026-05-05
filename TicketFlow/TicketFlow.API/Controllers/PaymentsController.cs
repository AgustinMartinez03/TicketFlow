using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response; // Necesario para PayReservationResponse y ApiError
using TicketFlow.Application.Exceptions; // Necesario para atrapar las excepciones personalizadas
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPayReservationUseCase _payReservationUseCase;

        public PaymentsController(IPayReservationUseCase payReservationUseCase)
        {
            _payReservationUseCase = payReservationUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PayReservationResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ProcessPayment([FromBody] PayReservationRequest request)
        {
            var response = await _payReservationUseCase.ExecuteAsync(request);
            return Created($"/api/v1/reservations/{response.ReservationId}", response);
        }
    }
}