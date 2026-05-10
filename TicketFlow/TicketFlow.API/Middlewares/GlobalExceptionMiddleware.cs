using System.Net;
using System.Text.Json;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;

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
                await _next(context);
            }
            catch (Exception ex) when (ex is ExceptionNotFound || ex is ExceptionBadRequest || ex is ExceptionConcurrency || ex is ExceptionConflict)
            {
                _logger.LogWarning($"Regla de negocio no cumplida: {ex.Message}");
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ha ocurrido un error CRÍTICO no controlado en la API.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var responseModel = new ApiError { Message = "Ocurrió un error interno en el servidor. Por favor, intente más tarde." };

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

            var result = JsonSerializer.Serialize(responseModel);
            return context.Response.WriteAsync(result);
        }
    }
}