namespace TicketFlow.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Venue { get; set; } = string.Empty;
        public string Status { get; set; } = "Active";

        // Opcional por ahora, pero buena práctica prepararla:
        // Propiedad de navegación para indicar que un Evento tiene muchos Sectores
        //public ICollection<Sector> Sectors { get; set; } = new List<Sector>();
    }
}
