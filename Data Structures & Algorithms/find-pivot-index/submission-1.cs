public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        for(int i = 0; i < nums.Length; i++)
        {
            int leftIndex = 0;
            int rightIndex = 0;

            for(int l = 0; l < i; l++)
            {
                leftIndex += nums[l];
            }

            for(int r = i + 1; r < nums.Length; r++)
            {
                rightIndex += nums[r];
            }

            if(leftIndex == rightIndex)
                return i;
        }

        return -1;
    }
}