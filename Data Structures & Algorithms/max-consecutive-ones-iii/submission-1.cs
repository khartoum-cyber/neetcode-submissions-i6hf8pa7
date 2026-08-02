public class Solution 
{
    public int LongestOnes(int[] nums, int k) 
    {
        int maxLen = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int zeros = 0;

            for(int j = i; j < nums.Length; j++)
            {
                if(nums[j] == 0)
                    zeros++;
                
                if(zeros > k)
                    break;
                    
                maxLen = Math.Max(maxLen, j - i + 1);
            }

        }

        return maxLen;
    }
}