namespace TicketFlow.Application.DTOs.Request
{
    public class PayReservationRequest
    {
        public Guid ReservationId { get; set; }
        // Simulamos un token de tarjeta de crédito (como si usáramos MercadoPago o Stripe)
        public string CreditCardToken { get; set; } = string.Empty;
    }
}