class Node
{
    public int val;
    public Node next;
    public Node prev;

    public Node(int value) 
    {
        val = value;
        next = null;
        prev = null;
    }
}

class Deque 
{
    private Node _head;
    private Node _tail;

    public Deque()
    {
        _head = new Node(0);
        _tail = new Node(0);

        _head.next = _tail;
        _tail.prev = _head;
    }

    public bool isEmpty() 
    {
        return _head.next == _tail;
    }

    public void append(int value) 
    {
        Node newNode = new Node(value);
        newNode.next = _tail;
        newNode.prev = _tail.prev;
        _tail.prev.next = newNode;
        _tail.prev = newNode;
    }

    public void appendleft(int value) 
    {
        Node newNode = new Node(value);
        newNode.prev = _head;
        newNode.next = _head.next;
        _head.next.prev = newNode;
        _head.next = newNode;
    }

    public int pop() 
    {
        if(isEmpty())
            return -1;
        
        Node targetNode = _tail.prev;
        Node prevNode = targetNode.prev;

        int value = targetNode.val;

        _tail.prev = prevNode;
        prevNode.next = _tail;

        return value;
    }

    public int popleft() 
    {
        if(isEmpty())
            return -1;

        Node targetNode = _head.next;
        Node nextNode = targetNode.next;

        int value = targetNode.val;

        _head.next = nextNode;
        nextNode.prev = _head;

        return value;
    }
}
