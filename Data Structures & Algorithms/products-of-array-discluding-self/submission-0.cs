public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int n = nums.Length;
        int[] res = new int[n];

        for(int i = 0; i < n; i++)
        {
            int product = 1;
            for(int j = 0; j < n; j++)
            {
                if(j != i)
                    product *= nums[j];
            }
            res[i] = product;
        }

        return res;
    }
}
