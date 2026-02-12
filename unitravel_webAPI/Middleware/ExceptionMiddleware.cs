using Newtonsoft.Json;

namespace unitravel_webAPI.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware (RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            Console.WriteLine($"[CRITICAL APP ERROR]: {ex.Message}");
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = 500;
            var response = new
            {
                success = false,
                error = "Internal Server Error. Please try again later or contact administrator."
            };
            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
