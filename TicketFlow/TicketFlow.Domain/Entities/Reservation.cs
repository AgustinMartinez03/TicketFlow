namespace TicketFlow.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public Guid SeatId { get; set; }
        public string Status { get; set; } = string.Empty; // Ej: "Pending", "Confirmed", "Cancelled"
        public DateTime ReservedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        // Propiedades de navegación
        public User User { get; set; } = null!;
        public Seat Seat { get; set; } = null!;
    }
}