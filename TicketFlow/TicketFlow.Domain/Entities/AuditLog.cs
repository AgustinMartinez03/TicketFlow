namespace TicketFlow.Domain.Entities
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string Action { get; set; } = string.Empty;      // Ej: "UPDATE", "RESERVE"
        public string EntityType { get; set; } = string.Empty;  // Ej: "Seat", "Reservation"
        public string EntityId { get; set; } = string.Empty;    // Guardamos el Guid o Int como string
        public string Details { get; set; } = string.Empty;     // Ej: "Cambio de Available a Sold"
        public DateTime CreatedAt { get; set; }
    }
}