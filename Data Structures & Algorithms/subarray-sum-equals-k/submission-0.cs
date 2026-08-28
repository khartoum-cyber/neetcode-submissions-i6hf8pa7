public class Solution 
{
    public int SubarraySum(int[] nums, int k) 
    {
        int res = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int currSum = 0;

            for(int j = i; j < nums.Length; j++)
            {
                currSum += nums[j];

                if(currSum == k)
                    res++;
            }
        }

        return res;
    }
}