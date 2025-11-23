using System.ComponentModel.Design;

namespace unitravel_webAPI.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly string _apiKey;

        public ApiKeyMiddleware(RequestDelegate requestDelegate, ApiKeySettings settings)
        {
            _requestDelegate = requestDelegate;
            _apiKey = settings.BridgeApiKey;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // maybe add exception for swagger, will leave it for the time being

            if(!context.Request.Headers.TryGetValue("X-API-Key", out var extractedKey))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Missing API Key!");
                return;
            }

            if (!_apiKey.Equals(extractedKey))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Invalid API Key!");
                return;
            }
            await _requestDelegate(context);
        }
    }
}
