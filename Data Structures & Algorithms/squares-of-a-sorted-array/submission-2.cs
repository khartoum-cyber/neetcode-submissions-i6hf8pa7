public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int n = nums.Length;

        int[] res = new int[n];

        int l = 0;
        int r = n - 1;
        int last = n - 1;

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