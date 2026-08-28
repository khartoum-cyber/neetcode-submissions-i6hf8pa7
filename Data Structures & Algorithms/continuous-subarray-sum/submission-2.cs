public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            int curSum = nums[i];

            for(int j = i + 1; j < nums.Length; j++)
            {
                curSum += nums[j];

                if(curSum % k == 0)
                    return true;
            }
        }

        return false;
    }
}