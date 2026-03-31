public class ListNode
{
    public int Value;
    public ListNode Next;

    public ListNode(int val)
    {
        Value = val;
        Next = null;
    }

    public ListNode(int val, ListNode next)
    {
        Value = val;
        Next = next;
    }
}

public class LinkedList 
{
    private ListNode _head;
    private ListNode _tail;

    public LinkedList() 
    {
        _head = new ListNode(-1);
        _tail = _head;
    }

    public int Get(int index) 
    {
        var cur = _head.Next;
        int i = 0;

        while(cur != null)
        {
            if(i == index)
                return cur.Value;

            cur = cur.Next;
            i++;
        }
        return -1;
    }

    public void InsertHead(int val) 
    {
        var newNode = new ListNode(val);
        newNode.Next = _head.Next;
        _head.Next = newNode;

        if(newNode.Next == null)
        {
            _tail = newNode;
        }
    }

    public void InsertTail(int val) 
    {
        _tail.Next = new ListNode(val);
        _tail = _tail.Next;
    }

    public bool Remove(int index) 
    {
        var cur = _head;
        int i = 0;

        while(cur != null && i < index)
        {
            i++;
            cur = cur.Next;
        }

        if(cur != null && cur.Next != null)
        {
            if(cur.Next == _tail)
                _tail = cur;
            
            cur.Next = cur.Next.Next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() 
    {
        List<int> values = new();
        var cur = _head.Next;

        while(cur != null)
        {
            values.Add(cur.Value);
            cur = cur.Next;
        }

        return values;
    }
}