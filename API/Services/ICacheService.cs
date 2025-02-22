namespace API.Services
{
    public interface ICacheService
    {   
        Task<T> GetOrSetAsync<T>(string key, Func<Task<T>> fetchFunction);
    }
}