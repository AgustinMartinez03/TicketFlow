namespace TicketFlow.Application.DTOs.Response
{
    public class PayReservationResponse
    {
        public Guid ReservationId { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}