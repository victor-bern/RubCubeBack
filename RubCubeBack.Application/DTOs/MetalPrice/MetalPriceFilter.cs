using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.MetalPrice
{
    public class MetalPriceFilter
    {
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public string? Currencies { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;

    }
}
