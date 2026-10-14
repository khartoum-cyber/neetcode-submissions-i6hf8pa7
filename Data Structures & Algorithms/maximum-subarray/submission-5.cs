public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSum = nums[0];
        int curSum = 0;

        foreach(var num in nums)
        {
            curSum = Math.Max(num, curSum + num);
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}
