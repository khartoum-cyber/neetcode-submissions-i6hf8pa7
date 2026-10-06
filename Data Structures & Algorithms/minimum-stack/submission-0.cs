public class MinStack 
{
    Stack<int> stack;

    public MinStack() 
    {
        stack = new();
    }
    
    public void Push(int val) 
    {
        stack.Push(val);
    }
    
    public void Pop() 
    {
        stack.Pop();
    }
    
    public int Top() 
    {
        return stack.Peek();
    }
    
    public int GetMin() 
    {
        Stack<int> tmp = new();
        int min = int.MaxValue;

        while(stack.Count > 0)
        {
            min = Math.Min(min, stack.Peek());
            tmp.Push(stack.Pop());
        }

        while(tmp.Count > 0)
        {
            stack.Push(tmp.Pop());
        }

        return min;
    }
}
