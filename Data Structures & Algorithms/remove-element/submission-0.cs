public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            if(nums[r] != val)
            {
                nums[k] = nums[r];
                k++;
            }
        }
        return k;
    }
}