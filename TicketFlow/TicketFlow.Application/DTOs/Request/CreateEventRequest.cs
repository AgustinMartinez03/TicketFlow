namespace TicketFlow.Application.DTOs.Request
{
    public class CreateEventRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        // Lista de sectores que el administrador quiere crear
        public List<CreateSectorRequest> Sectors { get; set; } = new List<CreateSectorRequest>();
    }
}