public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int n = heights.Length;

        int res = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = n - 1; j > i; j--)
            {
                int height = Math.Min(heights[i], heights[j]);
                int width = j - i;
                int curr = height * width;

                res = Math.Max(res, curr);
            }
        }

        return res;
    }
}
