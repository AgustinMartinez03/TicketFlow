namespace TicketFlow.Application.DTOs.Response
{
    public class PayReservationResponse
    {
        public List<Guid> ReservationIds { get; set; } = new List<Guid>();
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}