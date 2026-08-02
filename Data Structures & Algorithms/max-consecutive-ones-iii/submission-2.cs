public class Solution 
{
    public int LongestOnes(int[] nums, int k) 
    {
        int l = 0;
        int res = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            k -= (nums[r] == 0 ? 1 : 0);
            
            while(k < 0)
            {
                k += (nums[l] == 0 ? 1 : 0);
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}