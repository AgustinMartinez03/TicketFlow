namespace TicketFlow.Application.DTOs.Request
{
    public class CreateEventRequest
    {
        public string Name { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Venue { get; set; } = string.Empty;
    }
}