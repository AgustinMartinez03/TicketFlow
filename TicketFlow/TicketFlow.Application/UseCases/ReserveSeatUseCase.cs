using FluentValidation;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class ReserveSeatUseCase : IReserveSeatUseCase
    {
        private readonly ISeatCommand _seatCommand;
        private readonly IReservationCommand _reservationCommand;
        private readonly IAuditLogCommand _auditLogCommand;
        private readonly IValidator<ReserveSeatRequest> _validator; // 1. Declarar el validador

        // Inyectamos los 3 comandos
        public ReserveSeatUseCase(
            ISeatCommand seatCommand,
            IReservationCommand reservationCommand,
            IAuditLogCommand auditLogCommand,
            IValidator<ReserveSeatRequest> validator) // 2. Inyectarlo en el constructor)
        {
            _seatCommand = seatCommand;
            _reservationCommand = reservationCommand;
            _auditLogCommand = auditLogCommand;
            _validator = validator;
        }

        public async Task<string> ExecuteAsync(ReserveSeatRequest request)
        {
            // --- NUEVA LÍNEA DE DEFENSA: VALIDACIÓN ---
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                // Extraemos todos los mensajes de error y lanzamos una excepción
                var errors = string.Join(" | ", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new Exception($"Error de Validación: {errors}");
            }
            // ------------------------------------------

            // 1. Validar Butaca
            var seat = await _seatCommand.GetSeatByIdAsync(request.SeatId);
            if (seat == null) throw new Exception("La butaca no existe.");
            if (seat.Status != "Available") throw new Exception($"La butaca ya no está disponible. Estado: {seat.Status}");

            // 2. Modificar Butaca
            seat.Status = "Sold";
            _seatCommand.UpdateSeat(seat);

            // 3. Crear Reserva
            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                SeatId = seat.Id,
                Status = "Confirmed",
                ReservedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddHours(24) // Regla de negocio inventada: expira en 24hs
            };
            _reservationCommand.InsertReservation(reservation);

            // 4. Crear Log de Auditoría
            var auditLog = new AuditLog
            {
                UserId = request.UserId,
                Action = "RESERVE",
                EntityType = "Seat",
                EntityId = seat.Id.ToString(),
                Details = $"Usuario {request.UserId} reservó la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                CreatedAt = DateTime.UtcNow
            };
            _auditLogCommand.InsertAuditLog(auditLog);

            // 5. ¡Guardar todo junto en una sola transacción!
            await _seatCommand.SaveChangesAsync();

            return $"Reserva exitosa. Tu Nro de Comprobante es {reservation.Id}";
        }
    }
}