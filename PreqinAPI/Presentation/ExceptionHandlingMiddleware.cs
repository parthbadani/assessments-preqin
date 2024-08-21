using System.Net;

namespace Presentation
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Pass the context to the next middleware in the pipeline
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");

                // Generate a custom message based on the exception or request
                var customMessage = GenerateCustomMessage(context, ex);

                // Send the custom message as the response
                await SendCustomResponseAsync(context, customMessage, HttpStatusCode.InternalServerError);
            }
        }

        private string GenerateCustomMessage(HttpContext context, Exception ex)
        {
            // Create a custom message based on the request, exception, or other conditions
            return $"Exeption Middleware -- {ex.Message} -- {ex.StackTrace}";
        }

        private Task SendCustomResponseAsync(HttpContext context, string message, HttpStatusCode statusCode)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var response = new
            {
                statusCode = context.Response.StatusCode,
                message = message
            };

            // Send the response as JSON
            return context.Response.WriteAsJsonAsync(response);
        }
    }

}
