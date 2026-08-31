public class Solution 
{
    public int MaxAscendingSum(int[] nums) 
    {
        int maxSum = nums[0];
        int curSum = nums[0];

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > nums[i - 1])
            {
                curSum += nums[i];
            }
            else
            {
                curSum = nums[i];
            }

            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}