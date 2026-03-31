public class Solution {
    public int PivotIndex(int[] nums) 
    {
        int n = nums.Length;

        for(int i = 0; i < n; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for(int l = 0; l < i; l++)
            {
                leftSum += nums[l];
            }

            for(int r = i + 1; r < n; r++)
            {
                rightSum += nums[r];
            }

            if(leftSum == rightSum)
                return i;
        }
        return -1;
    }
}