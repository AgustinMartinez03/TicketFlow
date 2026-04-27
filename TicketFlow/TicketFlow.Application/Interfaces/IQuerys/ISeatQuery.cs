using TicketFlow.Domain.Entities; // Asegúrate de importar la entidad

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISeatQuery
    {
        // Cambiamos SeatResponse por Seat
        Task<IEnumerable<Seat>> GetSeatsBySectorAsync(int sectorId);
        Task<Seat?> GetSeatByIdAsync(Guid seatId);
    }
}