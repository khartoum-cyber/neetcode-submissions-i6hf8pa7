public class StockSpanner 
{
    private Stack<(int price, int span)> stack;

    public StockSpanner() 
    {
        stack = new();
    }
    
    public int Next(int price) 
    {
        int span = 1;

        while(stack.Count > 0 && price >= stack.Peek().price)
        {
            span += stack.Pop().span;
        }

        stack.Push((price, span));

        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */