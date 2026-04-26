using TicketFlow.Domain.Entities; // Asegúrate de importar la entidad

public interface IEventQuery
{
    // Ahora devuelve IEnumerable<Event>
    Task<(IEnumerable<Event> Events, int TotalRecords)> GetPaginatedEventsAsync(int pageNumber, int pageSize);
}
