using Microsoft.AspNetCore.Diagnostics;
using RubCubeBack.Application.Exceptions;

namespace RubCubeBack.Handlers
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            switch (exception)
            {
                case UnauthorizedAccessException:
                    httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await httpContext.Response.WriteAsJsonAsync(new { Error = exception.Message }, cancellationToken: cancellationToken);
                    return true;
                case UserNotFoundException:
                    httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                    await httpContext.Response.WriteAsJsonAsync(new { Error = exception.Message }, cancellationToken: cancellationToken);
                    return true;
            }

            return false;
        }
    }

}

