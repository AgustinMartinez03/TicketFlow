namespace TicketFlow.Application.Exceptions
{
    public class ExceptionConflict : Exception
    {
        public ExceptionConflict(string message) : base(message)
        {
        }
    }
}