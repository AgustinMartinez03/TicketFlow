using TicketFlow.Domain.Entities; // Asegurate de importar la entidad

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface IReservationQuery
    {
        // Antes devolvía DTOs, ahora devuelve la Entidad pura
        Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId);

        // (Si tenés el método GetSeatByIdAsync acá de la refactorización anterior, dejalo tal cual)
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
    }
}