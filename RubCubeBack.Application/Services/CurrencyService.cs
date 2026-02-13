using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.MetalPrice;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Application.Models.MetalPrice;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IMetalPriceClientService _metalPriceClientService;
        private readonly IRedisCacheService _redisCacheService;

        public CurrencyService(IMetalPriceClientService metalPriceClientService, IRedisCacheService redisCacheService)
        {
            _metalPriceClientService = metalPriceClientService;
            _redisCacheService = redisCacheService;
        }

        public async Task<ListItemsResponse<Dictionary<string, decimal>>> FetchCurrencyInfo(MetalPriceFilter filter, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var currenciesData = await _redisCacheService.GetAsync<MetalPriceResponse>($"currencies", cancellationToken);
            
            if(currenciesData is null)
            {
                currenciesData = await _metalPriceClientService.GetPriceAsync("BRL", cancellationToken);

                await _redisCacheService.SetAsync($"currencies", currenciesData, TimeSpan.FromHours(1), cancellationToken);
            }

            var currencies = filter.Currencies?.Split(',').Select(c => c.Trim()).ToList() ?? new List<string>();

            var items = currenciesData.Rates
                .Where(c => (currencies.Count == 0 || currencies.Contains(c.Key))
                && (!filter.MinValue.HasValue || c.Value >= filter.MinValue)
                && (!filter.MaxValue.HasValue || c.Value <= filter.MaxValue))
                .Skip((page - 1) * pageSize)
                .Take(pageSize).ToDictionary();


            return new ListItemsResponse<Dictionary<string, decimal>>
            {
                Items = items,
                Page = page,
                PageSize = pageSize,
            };


        }
    }
}
