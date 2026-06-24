public class Solution 
{
    public bool CanJump(int[] nums) 
    {
        return DFS(0, nums);
    }

    private bool DFS(int i, int[] nums)
    {
        //base case - check if we reached the end
        if(i == nums.Length - 1)
            return true;
        
        int end = Math.Min(nums.Length - 1, i + nums[i]);

        for(int j = end; j > i; j--)
        {
            if(DFS(j, nums))
                return true;
        }

        return false;
    }
}