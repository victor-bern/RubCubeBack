using Microsoft.Extensions.Configuration;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Application.Models.MetalPrice;
using RubCubeBack.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RubCubeBack.Infra.Clients
{
    public class MetalPriceClientService : IMetalPriceClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string apiKey;

        public MetalPriceClientService(IConfiguration configuration)
        {
            _configuration = configuration;
            var baseUrl = _configuration.GetValue<string>("MetalPriceApi:BaseUrl") ?? "";
            apiKey = _configuration.GetValue<string>("MetalPriceApi:ApiKey") ?? "";
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

        }


        public async Task<MetalPriceResponse> GetPriceAsync(string currencyCode)
        {
            var response = await _httpClient.GetFromJsonAsync<MetalPriceResponse>($"?api_key={apiKey}&base={currencyCode}");

            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new Exception("Error fetching metal prices");
            //}

            //var responseContent = await response.Content.ReadAsStringAsync();
            //var jsonResponse =  JsonSerializer.Deserialize<MetalPriceResponse>(responseContent);
            return response;
        }
    }
}
