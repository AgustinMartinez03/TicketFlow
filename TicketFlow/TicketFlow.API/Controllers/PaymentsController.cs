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
        public async Task<IActionResult> ProcessPayment([FromBody] PayReservationRequest request)
        {
            try
            {
                var response = await _payReservationUseCase.ExecuteAsync(request);

                // Devolvemos 201 Created. Como el pago impacta en la reserva, 
                // indicamos la URL de la reserva como ubicaciÃ³n del recurso modificado.
                return Created($"/api/v1/reservations/{response.ReservationId}", response);
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