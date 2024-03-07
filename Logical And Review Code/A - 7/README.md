# LPS A-7

### Analysis

1. The Cache class uses a static Dictionary<int, object> to store cached objects, with keys as integer identifiers and values as the cached objects.
2. The Add method adds a new key-value pair to the dictionary, while the Get method retrieves the object associated with a given key.
3. In the Main method, a loop populates the cache with a million objects, but there's no mechanism to limit the size of the cache or remove old entries.

### Improvements

To address the improper caching issue, we need to implement a mechanism to limit the size of the cache and evict old entries when the cache exceeds a certain size.

Here's the rewritten code:
```csharp
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

```

### Explanation:

1. I introduced a _keys field, which is a linked list to track the order of keys based on their usage.
2. I added a _capacity field to define the maximum size of the cache.
3. In the Add method, I check if the cache exceeds its capacity. If it does, I evict the oldest entry using the EvictOldestEntry method.
4. In the Get method, I move the accessed key to the end of the list to prioritize recently used items (MRU).
5. The EvictOldestEntry method removes the oldest entry from the cache based on the order in the _keys list.

By implementing this LRU caching strategy, the cache size is limited, and old entries are evicted when the cache reaches its capacity, preventing excessive memory consumption and ensuring efficient caching.





