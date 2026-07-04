public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int w = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            if(nums[r] != val)
                nums[w++] = nums[r];
        }

        return w;
    }
}