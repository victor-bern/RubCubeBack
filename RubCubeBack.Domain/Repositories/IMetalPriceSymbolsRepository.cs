using RubCubeBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Domain.Repositories
{
    public interface IMetalPriceSymbolsRepository
    {
        Task<IList<MetalPriceSymbols>> GetAvailableSymbols(CancellationToken cancellationToken);
    }
}
