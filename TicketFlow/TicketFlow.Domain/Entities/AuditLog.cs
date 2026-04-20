namespace TicketFlow.Domain.Entities
{
    public class AuditLog
    {
        public int Id { get; set; }      
        public int? UserId { get; set; }                        // Clave Foránea Nulable
        public string Action { get; set; } = string.Empty;      // Ej: "UPDATE", "RESERVE"
        public string EntityType { get; set; } = string.Empty;  // Ej: "Seat", "Reservation"
        public string EntityId { get; set; } = string.Empty;    // Guardamos el Guid o Int como string
        public string Details { get; set; } = string.Empty;     // Ej: "Cambio de Available a Sold"
        public DateTime CreatedAt { get; set; }

        // Propiedad de navegación
        public User? User { get; set; }
    }
}