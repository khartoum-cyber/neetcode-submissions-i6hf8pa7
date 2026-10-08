public class Solution 
{
    public int LongestSubarray(int[] nums, int limit) 
    {
        int n = nums.Length;
        int res = 0;
        
        for(int i = 0; i < n; i++)
        {
            int max = nums[i];
            int min = nums[i];

            for(int j = i; j < n; j++)
            {
                max = Math.Max(max, nums[j]);
                min = Math.Min(min, nums[j]);

                if(max - min <= limit)
                {
                    res = Math.Max(res, j - i + 1);
                }
            }
        }

        return res;
    }
}