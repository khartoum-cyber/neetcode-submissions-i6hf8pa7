public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int[] res = new int[nums.Length];

        int l = 0;
        int r = nums.Length - 1;
        int last = nums.Length - 1;

        while(l <= r)
        {
            if(Math.Abs(nums[l]) > Math.Abs(nums[r]))
            {
                res[last--] = nums[l] * nums[l];
                l++;
            }
            else
            {
                res[last--] = nums[r] * nums[r];
                r--;
            }
        }

        return res;
    }
}