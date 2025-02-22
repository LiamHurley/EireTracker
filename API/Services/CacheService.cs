using Microsoft.Extensions.Caching.Memory;

namespace API.Services
{    
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<T> GetOrSetAsync<T>(string key, Func<Task<T>> fetchFunction)
        {
            if (!_cache.TryGetValue(key, out T result))
            {
                result = await fetchFunction();

                // Set cache to expire at next 2AM
                DateTime now = DateTime.UtcNow;
                DateTime next2AM = now.Date.AddHours(2);
                if (now.Hour >= 2) next2AM = next2AM.AddDays(1);
                TimeSpan timeUntilNext2AM = next2AM - now;

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(timeUntilNext2AM);

                _cache.Set(key, result, cacheOptions);
            }

            return result;
        }
    }
}