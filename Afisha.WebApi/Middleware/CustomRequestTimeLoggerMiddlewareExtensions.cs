using Microsoft.AspNetCore.Builder;

namespace Afisha.WebApi.Middleware
{
    public static class CustomRequestTimeLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomRequestTimeLogger(this
            IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomRequestTimeLoggerMiddleware>();
        }
    }
}
