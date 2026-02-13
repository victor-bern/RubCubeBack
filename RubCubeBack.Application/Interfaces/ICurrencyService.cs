using RubCubeBack.Application.DTOs.Common;
using RubCubeBack.Application.DTOs.MetalPrice;
using RubCubeBack.Application.Models.MetalPrice;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface ICurrencyService
    {
        Task<ListItemsResponse<Dictionary<string, decimal>>> FetchCurrencyInfo(MetalPriceFilter filter, int page = 1, int pageSize = 10, CancellationToken cancellationToken = default);

    }
}
