using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RubCubeBack.Domain.Models;
using RubCubeBack.Domain.Repositories;
using Serilog;

namespace RubCubeBack.Infra.Middleware
{
    public class LogRequestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogRequestMiddleware> _logger;

        public LogRequestMiddleware(RequestDelegate next, ILogger<LogRequestMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Request.EnableBuffering();
            var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
            context.Request.Body.Position = 0;

            var userId = context.User.FindFirst("Id")?.Value;

            try
            {
                await _next(context);
            } catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if (!context.Request.Path.Value.Contains("swagger"))
                {
                    int statusCode = context.Response.StatusCode;
                    string path = context.Request.Path.Value;
                    Guid? userGuid = userId != null ? Guid.Parse(userId) : null;

                    Serilog.Log.ForContext("Id", Guid.NewGuid())
                        .ForContext("Path", path) // Agora é string
                        .ForContext("Request", requestBody)
                        .ForContext("UserId", userGuid)
                        .ForContext("Created", DateTime.UtcNow)
                        .ForContext("StatusCode", statusCode)
                        .Information("Request log");
                }

            }


 
        }

    }
}
