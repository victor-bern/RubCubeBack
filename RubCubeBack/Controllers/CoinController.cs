using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.DTOs.MetalPrice;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Application.Models.MetalPrice;
using RubCubeBack.Domain.Interfaces;
using RubCubeBack.Domain.Repositories;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoinController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMetalPriceSymbolsRepository _metalPriceSymbolsRepository;


        public CoinController(ICurrencyService currencyService, IMetalPriceSymbolsRepository metalPriceSymbolsRepository)
        {

            _metalPriceSymbolsRepository = metalPriceSymbolsRepository;
            _currencyService = currencyService;
        }

        [HttpGet("AvailableSymbols")]
        [Authorize]
        public async Task<IActionResult> GetAvailableSymbols(CancellationToken cancellationToken)
        {
            var symbols = await _metalPriceSymbolsRepository.GetAvailableSymbols(cancellationToken);
            return Ok(symbols);
        }

        [HttpGet("GetCoinsInfo")]
        [Authorize]
        public async Task<IActionResult> GetCoinsInfo([FromQuery] MetalPriceFilter filter, CancellationToken cancellationToken)
        {
            var coins = await _currencyService.FetchCurrencyInfo(filter, filter.Page, filter.PageSize, cancellationToken);
            return Ok(coins);
        }
    }
}
