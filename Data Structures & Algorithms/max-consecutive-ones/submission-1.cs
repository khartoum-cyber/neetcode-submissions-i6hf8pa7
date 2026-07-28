public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int currCount = 0;
        int maxCount = 0;

        foreach(var num in nums)
        {
            if(num == 1)
            {
                currCount++;
            }
            else
            {
                currCount = 0;
            }
            
            maxCount = Math.Max(currCount, maxCount);
        }

        return maxCount;
    }
}