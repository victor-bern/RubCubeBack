using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.DTOs.Auth;
using RubCubeBack.Application.Interfaces;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request, CancellationToken cancellationToken)
        {
            var tokenUser = await _authService.LoginAsync(request, cancellationToken);
            return Ok(tokenUser);
        }
    }
}
