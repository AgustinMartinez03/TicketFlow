namespace TicketFlow.Application.DTOs.Response
{
    public class ReserveSeatResponse
    {
        public Guid ReservationId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
