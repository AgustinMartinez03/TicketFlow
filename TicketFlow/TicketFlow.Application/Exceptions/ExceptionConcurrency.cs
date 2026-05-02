namespace TicketFlow.Application.Exceptions
{
    public class ExceptionConcurrency : Exception
    {
        public ExceptionConcurrency(string message) : base(message) { }
    }
}
