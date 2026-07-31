public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int max = 0;
        int curr = 0;

        foreach(var num in nums)
        {
            if(num == 1)
                curr++;
            else
            {
                max = Math.Max(max, curr);
                curr = 0;
            }
        }

        return Math.Max(max, curr);
    }
}