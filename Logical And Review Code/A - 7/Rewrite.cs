using System;
using System.Collections.Generic;

class Cache
{
    private static Dictionary<int, object> _cache = new Dictionary<int, object>();
    private static LinkedList<int> _keys = new LinkedList<int>();
    private static int _capacity = 1000; // Maximum cache size

    public static void Add(int key, object value)
    {
        if (_cache.Count >= _capacity)
        {
            EvictOldestEntry();
        }

        _cache[key] = value;
        _keys.AddLast(key);
    }

    public static object Get(int key)
    {
        if (_cache.ContainsKey(key))
        {
            // Move the accessed key to the end of the list (Most Recently Used)
            _keys.Remove(key);
            _keys.AddLast(key);
            return _cache[key];
        }
        else
        {
            return null;
        }
    }

    private static void EvictOldestEntry()
    {
        int oldestKey = _keys.First.Value;
        _keys.RemoveFirst();
        _cache.Remove(oldestKey);
    }
}

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 1000000; i++)
        {
            Cache.Add(i, new object());
        }
        Console.WriteLine("Cache populated");
        Console.ReadLine();
    }
}
