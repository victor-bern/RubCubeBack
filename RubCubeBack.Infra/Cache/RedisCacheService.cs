using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RubCubeBack.Application.Interfaces;


namespace RubCubeBack.Infra.Cache
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly IDistributedCache _cache;

        public RedisCacheService(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<T?> GetAsync<T>(string key, CancellationToken ct)
        {
            var data = await _cache.GetStringAsync(key, ct);
            return data == null ? default : JsonConvert.DeserializeObject<T>(data);
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan expiration, CancellationToken ct)
        {
            var options = new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = expiration };
            var data = JsonConvert.SerializeObject(value);
            await _cache.SetStringAsync(key, data, options, ct);
        }
    }
}
