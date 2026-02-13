using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Domain.Interfaces;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoinController : ControllerBase
    {
        private readonly IMetalPriceClientService _metalPriceClientService;

        public CoinController(IMetalPriceClientService metalPriceClientService)
        {
            _metalPriceClientService = metalPriceClientService;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetCoinsInfo()
        {
            var coins = await _metalPriceClientService.GetPriceAsync("BRL");

            return Ok(coins);
        }
    }
}
