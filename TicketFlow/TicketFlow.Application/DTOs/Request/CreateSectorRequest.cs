namespace TicketFlow.Application.DTOs.Request
{
    public class CreateSectorRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}
