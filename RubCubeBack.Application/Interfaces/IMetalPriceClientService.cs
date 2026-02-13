using RubCubeBack.Application.Models.MetalPrice;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IMetalPriceClientService
    {
        Task<MetalPriceResponse> GetPriceAsync(string currencyCode);
    }
}
