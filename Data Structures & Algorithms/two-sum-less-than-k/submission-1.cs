public class Solution 
{
    public int TwoSumLessThanK(int[] nums, int k) 
    {
        Array.Sort(nums);

        int l = 0;
        int r = nums.Length - 1;

        int maxSum = -1;

        while(l < r)
        {
            int curSum = nums[l] + nums[r];

            if(curSum < k)
            {
                maxSum = Math.Max(maxSum, curSum);
                l++;
            }
            else
            {
                r--;
            }
        }

        return maxSum;
    }
}
