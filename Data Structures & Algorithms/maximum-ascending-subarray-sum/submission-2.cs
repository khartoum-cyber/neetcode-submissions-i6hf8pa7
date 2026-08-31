public class Solution 
{
    public int MaxAscendingSum(int[] nums) 
    {
        int maxSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int curSum = nums[i];

            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] <= nums[j - 1])
                    break;

                curSum += nums[j];

            }
            
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}