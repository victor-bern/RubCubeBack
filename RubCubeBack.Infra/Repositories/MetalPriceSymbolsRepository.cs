using Microsoft.EntityFrameworkCore;
using RubCubeBack.Domain.Models;
using RubCubeBack.Domain.Repositories;
using RubCubeBack.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Infra.Repositories
{
    public class MetalPriceSymbolsRepository : IMetalPriceSymbolsRepository
    {
        private readonly RubAppDbContext _context;

        public MetalPriceSymbolsRepository(RubAppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<MetalPriceSymbols>> GetAvailableSymbols(CancellationToken cancellationToken)
        {
            return await _context.MetalPriceSymbols.AsNoTracking().ToListAsync(cancellationToken);
        }
    }
}
