using DesignPatterns.Structural.Facade.Entity;

namespace DesignPatterns.Structural.Facade.Service.Cache;

public class CacheService
{
    private readonly Dictionary<string, OrderEntity> _cache = new();
    
    public void CacheData(string key, OrderEntity value)
    {
        _cache[key] = value;
        Console.WriteLine($"Caching data: {key} = {value}");
    }

    public OrderEntity? GetCachedData(string key)
    {
        Console.WriteLine($"Retrieving cached data for key: {key}");
        if (_cache.ContainsKey(key))
            return _cache[key];

        return null; // Placeholder return value
    }

    public void ClearCache()
    {
        _cache.Clear();
        Console.WriteLine("Cache cleared.");
    }
}