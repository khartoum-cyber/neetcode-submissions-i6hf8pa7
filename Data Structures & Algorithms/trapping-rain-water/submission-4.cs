public class Solution 
{
    public int Trap(int[] height) 
    {
        int res = 0;
        Stack<int> stack = new();

        for(int i = 0; i < height.Length; i++)
        {
            while(stack.Count > 0 && height[i] >= height[stack.Peek()])
            {
                int idx = stack.Pop();

                if(stack.Count > 0)
                {
                    int distance = i - stack.Peek() - 1;
                    int boundedHeight = Math.Min(height[i], height[stack.Peek()]) - height[idx];
                    res += distance * boundedHeight;
                }

            }

            stack.Push(i);
        }

        return res;
    }
}
