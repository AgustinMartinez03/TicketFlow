using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class PayReservationUseCase : IPayReservationUseCase
    {
        private readonly IReservationQuery _reservationQuery;
        private readonly ISeatQuery _seatQuery;
        private readonly IReservationCommand _reservationCommand;
        private readonly ISeatCommand _seatCommand;
        private readonly IAuditLogCommand _auditLogCommand;
        private readonly IReservationMapper _reservationMapper;

        public PayReservationUseCase(
            IReservationQuery reservationQuery,
            ISeatQuery seatQuery,
            IReservationCommand reservationCommand,
            ISeatCommand seatCommand,
            IAuditLogCommand auditLogCommand,
            IReservationMapper reservationMapper)
        {
            _reservationQuery = reservationQuery;
            _seatQuery = seatQuery;
            _reservationCommand = reservationCommand;
            _seatCommand = seatCommand;
            _auditLogCommand = auditLogCommand;
            _reservationMapper = reservationMapper;
        }

        public async Task<PayReservationResponse> ExecuteAsync(PayReservationRequest request)
        {
            if (request.ReservationIds == null || !request.ReservationIds.Any())
                throw new ExceptionBadRequest("No hay reservas para pagar.");

            if (string.IsNullOrWhiteSpace(request.CreditCardToken))
                throw new ExceptionBadRequest("Token de tarjeta inválido.");

            // 🚀 INICIAMOS LA TRANSACCIÓN: Todo o nada a partir de acá
            await _seatCommand.BeginTransactionAsync();

            try
            {
                // Iteramos sobre cada ID de reserva que nos manda el Front
                foreach (var resId in request.ReservationIds)
                {
                    var reservation = await _reservationQuery.GetReservationByIdAsync(resId);
                    if (reservation == null)
                        throw new ExceptionNotFound($"La reserva {resId} no existe.");

                    if (reservation.Status != "Pending")
                        throw new ExceptionBadRequest($"La reserva {resId} no se puede pagar porque su estado es: {reservation.Status}");

                    var seat = await _seatQuery.GetSeatByIdAsync(reservation.SeatId);
                    if (seat == null)
                        throw new ExceptionNotFound($"La butaca asociada a la reserva {resId} no existe.");

                    // 2. Actualizar Reserva
                    reservation.Status = "Completed";
                    _reservationCommand.UpdateReservation(reservation);

                    // 3. Actualizar Butaca
                    seat.Status = "Sold";
                    seat.Version++; // Mantenemos la sana costumbre de la concurrencia
                    _seatCommand.UpdateSeat(seat);

                    // 4. Auditoría
                    var auditLog = new AuditLog
                    {
                        UserId = reservation.UserId,
                        Action = "PAYMENT_SUCCESS",
                        EntityType = "Reservation",
                        EntityId = reservation.Id.ToString(),
                        Details = $"Pago confirmado para la butaca {seat.RowIdentifier}-{seat.SeatNumber}",
                        CreatedAt = DateTime.UtcNow
                    };
                    _auditLogCommand.InsertAuditLog(auditLog);
                }

                // 5. Guardar cambios en BD
                await _seatCommand.SaveChangesAsync();

                // 6. Si llegamos acá sin errores, confirmamos la transacción de BD
                await _seatCommand.CommitTransactionAsync();

                // Retornamos la respuesta (incluyendo el Status que me mencionaste)
                return _reservationMapper.MapToPayReservationResponse(
                    request.ReservationIds,
                    "El pago se procesó correctamente. ¡Disfruta el evento!",
                    "Success"
                );
            }
            catch (Exception)
            {
                // 🛑 SI ALGO FALLÓ (ej: error en BD, corte de luz simulado), DESHACEMOS TODO
                await _seatCommand.RollbackTransactionAsync();
                throw; // Relanzamos el error para que el middleware lo atrape
            }
        }
    }
}