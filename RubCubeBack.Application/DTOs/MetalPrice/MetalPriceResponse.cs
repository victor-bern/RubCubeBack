using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RubCubeBack.Application.Models.MetalPrice
{
    public class MetalPriceResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("base")]
        public string Base { get; set; }
        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
        [JsonPropertyName("rates")]
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
