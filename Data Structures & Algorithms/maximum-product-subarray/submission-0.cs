public class Solution 
{
    public int MaxProduct(int[] nums) 
    {
        int res = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = 1;
            
            for(int j = i; j < nums.Length; j++)
            {
                curr *= nums[j];
                res = Math.Max(res, curr);
            }
        }

        return res;
    }
}
