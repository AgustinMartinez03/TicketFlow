using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.ICommands
{
    public interface IReservationCommand
    {
        void InsertReservation(Reservation reservation);
        // 👇 AÑADIMOS EL NUEVO CONTRATO
        void UpdateReservation(Reservation reservation);
    }
    // Nota de Diseño: Se omite el método SaveChangesAsync en esta interfaz.
    // La persistencia de la transacción completa (Reserva + Butaca + Auditoría) 
    // es coordinada por el Caso de Uso para garantizar atomicidad.
}