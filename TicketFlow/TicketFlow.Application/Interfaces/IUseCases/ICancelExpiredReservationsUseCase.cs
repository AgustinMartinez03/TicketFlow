namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface ICancelExpiredReservationsUseCase
    {
        Task ExecuteAsync();
    }
}