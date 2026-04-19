using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class ReserveSeatUseCase : IReserveSeatUseCase
    {
        private readonly ISeatCommand _seatCommand;

        public ReserveSeatUseCase(ISeatCommand seatCommand)
        {
            _seatCommand = seatCommand;
        }

        public async Task<string> ExecuteAsync(Guid seatId)
        {
            // 1. Buscar la butaca
            var seat = await _seatCommand.GetSeatByIdAsync(seatId);

            /* Lanzar una Exception genérica no es la práctica más "limpia" del mundo,
             * deberíamos usar Excepciones Personalizadas o un patrón Result, 
             * pero para esta primera iteración rápida, cumple su función perfectamente*/
            if (seat == null)
            {
                throw new Exception($"La butaca con ID {seatId} no existe.");
            }

            // 2. Regla de negocio: Verificar disponibilidad
            if (seat.Status != "Available")
            {
                throw new Exception($"La butaca {seat.RowIdentifier}-{seat.SeatNumber} ya no está disponible. Estado actual: {seat.Status}");
            }

            // 3. Cambiar el estado y guardar
            seat.Status = "Sold";
            _seatCommand.UpdateSeat(seat);
            await _seatCommand.SaveChangesAsync();

            return $"Reserva exitosa para la butaca {seat.RowIdentifier}-{seat.SeatNumber}.";
        }
    }
}