namespace TicketFlow.Application.DTOs.Response
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }

        // Constructores para facilitar su uso luego
        public GenericResponse(T data, string message = "")
        {
            Success = true;
            Message = message;
            Data = data;
        }

        public GenericResponse(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
