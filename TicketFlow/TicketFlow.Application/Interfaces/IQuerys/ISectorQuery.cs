using TicketFlow.Domain.Entities; // Asegúrate de importar la entidad

namespace TicketFlow.Application.Interfaces.IQuerys
{
    public interface ISectorQuery
    {
        // Ahora devuelve una colección de entidades puras
        Task<IEnumerable<Sector>> GetSectorsByEventAsync(int eventId);
    }
}