using Microsoft.AspNetCore.Mvc;
using TicketFlow.Application.DTOs.Request;
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
        public async Task<IActionResult> ProcessPayment([FromBody] PayReservationRequest request)
        {
            var response = await _payReservationUseCase.ExecuteAsync(request);
            return Ok(response);
        }
    }
}