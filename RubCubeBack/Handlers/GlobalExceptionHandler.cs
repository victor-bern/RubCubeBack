using Microsoft.AspNetCore.Diagnostics;
using RubCubeBack.Application.Exceptions;

namespace RubCubeBack.Handlers
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is UnauthorizedException)
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await httpContext.Response.WriteAsJsonAsync(new { Error = exception.Message }, cancellationToken: cancellationToken);
                return true;            
            }

            return false;
        }
    }

}

