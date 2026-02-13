using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.DTOs.User;
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
        //[Authorize]
        public async Task<IActionResult> GetUsers([FromQuery] UserFilterDTO filter, CancellationToken cancellationToken)
        {
            var users = await _userService.GetUsersAsync(filter, cancellationToken);
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


        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequestDTO request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;

            var user = await _userService.UpdateUserAsync(Guid.Parse(userId), request, cancellationToken);

            return Ok(user);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteUser(CancellationToken cancellationToken)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            await _userService.DeleteUserAsync(Guid.Parse(userId), cancellationToken);
            return NoContent();
        }
    }

}