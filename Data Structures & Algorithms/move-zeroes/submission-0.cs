public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int w = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            if(nums[r] != 0)
                nums[w++] = nums[r];
        }

        while(w < nums.Length)
        {
            nums[w++] = 0;
        }
    }
}