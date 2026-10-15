public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int max = nums[0];
        int curr = 0;

        foreach(var num in nums)
        {
            curr = Math.Max(num, curr + num);
            max = Math.Max(curr, max);
        }

        return max;
    }
}
