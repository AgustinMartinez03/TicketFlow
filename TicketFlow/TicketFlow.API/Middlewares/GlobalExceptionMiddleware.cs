using System.Net;
using System.Text.Json;
using TicketFlow.Application.DTOs.Response; // Para usar tu clase ApiError
using TicketFlow.Application.Exceptions; // Para reconocer tus excepciones de negocio

namespace TicketFlow.API.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Dejamos que la petición siga su curso normal hacia el Controller
                await _next(context);
            }
            catch (Exception ex)
            {
                // Si CUALQUIER error no atrapado explota, cae acá.
                _logger.LogError(ex, "Ha ocurrido un error no controlado en la API.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            // Por defecto, asumimos que es un error 500 (Error interno del servidor)
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var responseModel = new ApiError { Message = "Ocurrió un error interno en el servidor. Por favor, intente más tarde." };

            // Si es un error de negocio que se nos escapó atrapar en el controller, lo mapeamos:
            switch (exception)
            {
                case ExceptionNotFound e:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    responseModel.Message = e.Message;
                    break;
                case ExceptionBadRequest e:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    responseModel.Message = e.Message;
                    break;
                case ExceptionConcurrency e:
                    context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                    responseModel.Message = e.Message;
                    break;
                case ExceptionConflict e:
                    context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                    responseModel.Message = e.Message;
                    break;
            }

            // En un entorno de desarrollo, podrías devolver exception.Message en el 500 para debugear, 
            // pero en producción siempre es mejor dar un mensaje genérico para no exponer código interno.

            var result = JsonSerializer.Serialize(responseModel);
            return context.Response.WriteAsync(result);
        }
    }
}