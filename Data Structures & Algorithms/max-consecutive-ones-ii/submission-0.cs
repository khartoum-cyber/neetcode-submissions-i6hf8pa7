public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int max = 0;
        int curr = 0;
        int prev = 0;
        bool isFlipped = false;

        foreach(var num in nums)
        {
            if(num == 1)
                curr++;
            else
            {
                isFlipped = true;
                prev = curr + 1;
                curr = 0;
            }

            max = Math.Max(max, isFlipped ? curr + prev : curr);
        }

        return max;
    }
}