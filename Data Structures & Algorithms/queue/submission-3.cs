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
        Node newTail = new Node(value);
        newTail.next = dummyTail;
        newTail.prev = dummyTail.prev;
        dummyTail.prev.next = newTail;
        dummyTail.prev = newTail;
    }

    public void appendleft(int value) 
    {
        Node newHead = new Node(value);
        newHead.prev = dummyHead;
        newHead.next = dummyHead.next;
        dummyHead.next.prev = newHead;
        dummyHead.next = newHead;
    }

    public int pop() 
    {
        if(isEmpty())
            return -1;
        
        Node targetNode = dummyTail.prev;
        Node prevNode = targetNode.prev;

        int value = targetNode.val;

        dummyTail.prev = prevNode;
        prevNode.next = dummyTail;

        return value;
    }

    public int popleft() 
    {
        if(isEmpty())
            return -1;
        
        Node targetNode = dummyHead.next;
        Node nextNode = targetNode.next;

        int value = targetNode.val;

        dummyHead.next = nextNode;
        nextNode.prev = dummyHead;

        return value;
    }
}
