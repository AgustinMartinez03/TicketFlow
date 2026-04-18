namespace TicketFlow.Application.DTOs.Response
{
    public class SectorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}
