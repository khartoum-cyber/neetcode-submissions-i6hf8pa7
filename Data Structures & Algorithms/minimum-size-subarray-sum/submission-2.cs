public class Solution 
{
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int minLen = int.MaxValue;
        int left = 0;
        int currSum = 0;

        for(int right = 0; right < nums.Length; right++)
        {
            currSum += nums[right];

            while(currSum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                currSum -= nums[left];
                left++;
            }
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}