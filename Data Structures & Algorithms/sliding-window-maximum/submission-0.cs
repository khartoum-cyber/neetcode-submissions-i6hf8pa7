public class Solution 
{
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        int n = nums.Length;
        int[] res = new int[n - k + 1];

        for(int i = 0; i <= n - k; i++)
        {
            int maxNum = nums[i];

            for(int j = i + 1; j < i + k; j++)
            {
                maxNum = Math.Max(maxNum, nums[j]);
            }

            res[i] = maxNum;
        }

        return res;
    }
}
