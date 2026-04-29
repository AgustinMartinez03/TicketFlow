namespace TicketFlow.Application.DTOs.Response
{
    public class UserReservationResponse
    {
        public Guid ReservationId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Venue { get; set; } = string.Empty;
        public string SectorName { get; set; } = string.Empty;
        public string SeatDetails { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
