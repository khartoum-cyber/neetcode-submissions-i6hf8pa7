public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int count = 0;
        int currCount = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
                currCount++;
            else
                currCount = 0;
            
            count = Math.Max(count, currCount);
        }

        return count;
    }
}