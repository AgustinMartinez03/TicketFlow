using FluentValidation;
using TicketFlow.Application.DTOs.Request;

namespace TicketFlow.Application.Validators
{
    // Heredamos de AbstractValidator e indicamos qué DTO vamos a validar
    public class ReserveSeatRequestValidator : AbstractValidator<ReserveSeatRequest>
    {
        public ReserveSeatRequestValidator()
        {
            // Regla 1: El SeatId no puede estar vacío (no puede ser un Guid de puros ceros)
            RuleFor(x => x.SeatId)
                .NotEmpty().WithMessage("El ID de la butaca es obligatorio.");

            // Regla 2: El UserId debe ser un número real y positivo
            RuleFor(x => x.UserId)
                .GreaterThan(0).WithMessage("El ID del usuario debe ser mayor a cero.");
        }
    }
}