namespace TicketFlow.Application.DTOs.Request
{
    public class ReserveSeatRequest
    {
        public Guid SeatId { get; set; }
        public int UserId { get; set; }
    }
}