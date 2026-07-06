public class Solution 
{
    public int TwoSumLessThanK(int[] nums, int k) 
    {
        Array.Sort(nums);

        int l = 0;
        int r = nums.Length - 1;

        int curMax = -1;

        while (l < r) 
        {
            int curSum = nums[l] + nums[r];

            if(curSum < k)
            {
                curMax = Math.Max(curMax, curSum);
                l++;
            }
            else
            {
                r--;
            }
        }
        return curMax;
    }
}
