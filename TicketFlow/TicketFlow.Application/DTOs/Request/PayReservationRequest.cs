namespace TicketFlow.Application.DTOs.Request
{
    public class PayReservationRequest
    {
        public List<Guid> ReservationIds { get; set; } = new List<Guid>();
        public string CreditCardToken { get; set; } = string.Empty;
    }
}