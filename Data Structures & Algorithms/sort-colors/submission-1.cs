public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int l = 0;
        int r = nums.Length - 1;
        int m = 0;

        while(m <= r)
        {
            if(nums[m] == 0)
            {
                (nums[m], nums[l]) = (nums[l], nums[m]);
                l++;
                m++;
            }
            else if(nums[m] == 1)
            {
                m++;
            }
            else
            {
                (nums[m], nums[r]) = (nums[r], nums[m]);
                r--;
            }
        }
    }
}