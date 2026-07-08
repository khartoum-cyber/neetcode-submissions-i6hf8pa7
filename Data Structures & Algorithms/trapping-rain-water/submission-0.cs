public class Solution 
{
    public int Trap(int[] height) 
    {
        if(height.Length == 0 || height == null)
            return 0;
        
        int res = 0;
        int n = height.Length;

        int[] leftMax = new int[n];
        int[] rightMax = new int[n];

        leftMax[0] = height[0];
        for(int i = 1; i < n; i++)
            leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
        
        rightMax[n - 1] = height[n - 1];
        for(int i = n - 2; i >= 0; i--)
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        
        for(int i = 0; i < n; i++)
            res += Math.Min(leftMax[i], rightMax[i]) - height[i];

        return res;
    }
}
