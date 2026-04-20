using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface IReservationCommand
    {
        void InsertReservation(Reservation reservation);
    }
    /* Nota: No les ponemos SaveChangesAsync a estas interfaces porque usaremos 
     * el del ISeatCommand para guardar todo en una sola transacción*/
}