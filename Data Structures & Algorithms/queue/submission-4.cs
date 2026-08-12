class Node
{
    public int val;
    public Node next;
    public Node prev;

    public Node(int value)
    {
        this.val = value;
        this.next = null;
        this.prev = null;
    }
}

class Deque 
{
    private Node dummyHead;
    private Node dummyTail;

    public Deque() 
    {
        dummyHead = new Node(0);
        dummyTail = new Node(0);

        dummyHead.next = dummyTail;
        dummyTail.prev = dummyHead;
    }

    public bool isEmpty() 
    {
        return dummyHead.next == dummyTail;
    }

    public void append(int value) 
    {
        Node newTail = new(value);
        newTail.next = dummyTail;
        newTail.prev = dummyTail.prev;
        dummyTail.prev.next = newTail;
        dummyTail.prev = newTail;
    }

    public void appendleft(int value) 
    {
        Node newHead = new(value);
        newHead.prev = dummyHead;
        newHead.next = dummyHead.next;
        dummyHead.next.prev = newHead;
        dummyHead.next = newHead;
    }

    public int pop() 
    {
        if(isEmpty())
            return -1;

        Node target = dummyTail.prev;
        Node previous = target.prev;

        int value = target.val;

        dummyTail.prev = previous;
        previous.next = dummyTail;

        return value;
    }

    public int popleft() 
    {
        if(isEmpty())
            return -1;
        
        Node next = dummyHead.next.next;

        int value = dummyHead.next.val;

        dummyHead.next = next;
        next.prev = dummyHead;

        return value;
    }
}
