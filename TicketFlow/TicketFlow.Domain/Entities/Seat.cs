namespace TicketFlow.Domain.Entities
{
    public class Seat
    {
        public Guid Id { get; set; }
        public int SectorId { get; set; }
        public string RowIdentifier { get; set; } = string.Empty;
        public int SeatNumber { get; set; }
        public string Status { get; set; } = "Available";
        public int Version { get; set; }

        public Sector Sector { get; set; } = null!;
    }
}
