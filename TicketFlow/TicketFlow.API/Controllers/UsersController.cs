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

        // GET: api/v1/reservations
        [HttpGet("{id}/reservations")]
        [ProducesResponseType(typeof(List<UserReservationResponse>), StatusCodes.Status200OK)] // <- Corregido a List
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]              // <- Documentado
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]            // <- Documentado
        public async Task<IActionResult> GetUserReservations(int id)
        {
            try
            {
                // El controlador ejecuta a ciegas
                var results = await _getUserReservationUseCase.ExecuteAsync(id);
                return Ok(results);
            }
            catch (ExceptionNotFound ex)
            {
                // Atrapa si el usuario no tiene reservas
                return NotFound(new ApiError { Message = ex.Message });
            }
            catch (ExceptionBadRequest ex)
            {
                // Atrapa si le pasamos un ID negativo o cero
                return BadRequest(new ApiError { Message = ex.Message });
            }
        }
    }
}