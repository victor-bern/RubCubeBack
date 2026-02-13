using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.Interfaces
{
    public interface IRedisCacheService
    {
        Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken);
        Task SetAsync<T>(string key, T value, TimeSpan expiration, CancellationToken cancellationToken);
    }
}
