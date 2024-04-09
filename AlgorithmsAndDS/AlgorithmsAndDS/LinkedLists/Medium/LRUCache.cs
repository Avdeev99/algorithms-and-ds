namespace AlgorithmsAndDS.LinkedLists.Medium;

// 146. LRU Cache
public class LRUCache
{
    private Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map = new();
    private LinkedList<KeyValuePair<int, int>> cache = new();
    private int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }
    
    public int Get(int key)
    {
        var inCache = map.TryGetValue(key, out var node);

        if (!inCache)
            return -1;

        cache.Remove(node);
        cache.AddFirst(node);

        return node.Value.Value;
    }
    
    public void Put(int key, int value)
    {
        var newNode = new LinkedListNode<KeyValuePair<int, int>>(
            new KeyValuePair<int, int>(key, value)
        );

        var inCache = map.TryGetValue(key, out var node);

        if (!inCache && cache.Count >= capacity)
        {
            var last = cache.Last.Value;
            map.Remove(last.Key);
            cache.RemoveLast();
        }

        if (inCache)
            cache.Remove(node);
        
        map[key] = newNode;
        cache.AddFirst(newNode);
    }
}