public class Solution 
{
    public int MaxProduct(int[] nums) 
    {
        int res = nums[0];
        int curMax = 1;
        int curMin = 1;

        foreach(var num in nums)
        {
            int temp = curMax * num;
            curMax = Math.Max(Math.Max(num * curMax, num * curMin), num);
            curMin = Math.Min(Math.Min(temp, num * curMin), num);
            res = Math.Max(res, curMax);
        }

        return res;
    }
}
