public class Solution 
{
    public int LongestOnes(int[] nums, int k) 
    {
        int l = 0;
        int res = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            if(nums[r] == 0)
                k--;
            
            while(k < 0)
            {
                if(nums[l] == 0)
                    k++;
                
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}