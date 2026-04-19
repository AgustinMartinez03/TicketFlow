namespace TicketFlow.Application.Interfaces.IUseCases
{
    public interface IReserveSeatUseCase
    {
        // Devolveremos un string con el resultado para hacerlo sencillo por ahora
        Task<string> ExecuteAsync(Guid seatId);
    }
}