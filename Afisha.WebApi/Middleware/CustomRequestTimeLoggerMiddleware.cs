using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Afisha.WebApi.Middleware
{
    public class CustomRequestTimeLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public CustomRequestTimeLoggerMiddleware(RequestDelegate next,
            ILogger<CustomRequestTimeLoggerMiddleware> logger) => (_next, _logger) = (next, logger);

        public async Task InvokeAsync(HttpContext context)
        {
            DateTimeOffset Begin = DateTimeOffset.Now;
            try
            {
                await _next.Invoke(context);
            }
            finally
            {
                DateTimeOffset End = DateTimeOffset.Now;
                _logger.LogInformation($"Request Time: BEGIN [{Begin.ToString("HH:mm:ss:fffffff")}] | " +
                    $"END [{End.ToString("HH:mm:ss:fffffff")}] | " +
                    $"Elapsed [{End - Begin}]");
            }
        }
    }
}
