namespace TicketFlow.Application.DTOs.Request
{
    public class CreateEventRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public List<CreateSectorRequest> Sectors { get; set; } = new List<CreateSectorRequest>();
    }
}