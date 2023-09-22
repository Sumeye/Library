using Library.Core.DTO;
using Library.Service.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Library.UI.Middlewares
{
    public class UseCustomExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public UseCustomExceptionHandler(RequestDelegate next,ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError("--------------------------EXCEPTION--------------------------------");
                _logger.LogError($"Status Code: {httpContext.Response.StatusCode}");
                _logger.LogError($"Request Path: {httpContext.Request.Path}");
                _logger.LogError($"Request Method: {httpContext.Request.Method}");
                _logger.LogError($"Exception Message: {ex.Message}");
                _logger.LogError("--------------------------EXCEPTION--------------------------------");
            }
        } 
    }
}
