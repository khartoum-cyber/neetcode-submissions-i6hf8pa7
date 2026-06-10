public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSum = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            int currSum = 0;
            for(int j = i; j < nums.Length; j++)
            {
                currSum += nums[j];

                if(currSum > maxSum)
                    maxSum = currSum;
            }
        }

        return maxSum;
    }
}
