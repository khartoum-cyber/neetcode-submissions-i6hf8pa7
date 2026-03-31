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
        var curr = _head.Next;
        int i = 0;

        while(curr != null)
        {
            if(i == index)
                return curr.Value;

            i++;
            curr = curr.Next;
        }
        return -1;
    }

    public void InsertHead(int val) 
    {
        var newNode = new ListNode(val);
        newNode.Next = _head.Next;
        _head.Next = newNode;

        if(newNode.Next == null)
            _tail = newNode;
    }

    public void InsertTail(int val) {
        _tail.Next = new ListNode(val);
        _tail = _tail.Next;
    }

    public bool Remove(int index) {
        int i = 0;
        var curr = _head;

        while(i < index && curr != null)
        {
            i++;
            curr = curr.Next;
        }

        if(curr != null && curr.Next != null)
        {
            if(curr.Next == _tail)
                _tail = curr;

            curr.Next = curr.Next.Next;
            return true;
        }

        return false;
    }

    public List<int> GetValues() {
        List<int> values = new List<int>();
        var curr = _head.Next;

        while(curr != null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }
        return values;
    }
}