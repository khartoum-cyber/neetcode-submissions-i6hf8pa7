public class Node
{
    public int value;
    public int key;
    public Node next;
    public Node prev;

    public Node(int key, int val)
    {
        this.key = key;
        this.value = val;
        this.next = null;
        this.prev = null;
    }
}

public class LRUCache 
{
    private int cap;
    private Dictionary<int,Node> cache;
    private Node left;
    private Node right;

    public LRUCache(int capacity) 
    {
        left = new(0, 0);
        right = new(0, 0);

        left.next = right;
        right.prev = left;

        cap = capacity;
        cache = new();
    }

    private void Remove(Node node)
    {
        Node previous = node.prev;
        previous.next = node.next;
        node.next.prev = previous;
    }

    private void Insert(Node node)
    {
        Node prev = right.prev;
        prev.next = node;
        node.prev = prev;
        node.next = right;
        right.prev = node;
    }
    
    public int Get(int key) 
    {
        if(!cache.ContainsKey(key))
            return -1;
        
        Node node = cache[key];
        Remove(node);
        Insert(node);

        return node.value;
    }
    
    public void Put(int key, int value) 
    {
        if(cache.ContainsKey(key))
            Remove(cache[key]);
        
        Node newNode = new Node(key, value);
        cache[key] = newNode;
        Insert(newNode);

        if(cache.Count > cap)
        {
            Node lru = left.next;
            Remove(lru);
            cache.Remove(lru.key);
        }
    }
}
