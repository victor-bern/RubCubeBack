using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoinController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetCoinsInfo()
        {
            return Ok(new
            {
                Name = "RubCube Coin",
                Symbol = "RCC",
                TotalSupply = 1000000,
                Decimals = 18
            });
        }
    }
}
