using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.DTOs;
using RubCubeBack.Application.Interfaces;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        {
            var users = await _userService.GetUsersAsync(cancellationToken);
            return Ok(users);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDTO request, CancellationToken cancellationToken)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userService.CreateUserAsync(request, cancellationToken);
            return Ok(user);
        }
    }
}
