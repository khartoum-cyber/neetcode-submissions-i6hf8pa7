public class Solution 
{
    public bool CanJump(int[] nums) 
    {
        Dictionary<int,bool> memo = new();
        return DFS(0, nums, memo);
    }

    private bool DFS(int i, int[] nums, Dictionary<int,bool> memo)
    {
        if(i == nums.Length - 1)
            return true;
        
        if(memo.ContainsKey(i))
            return memo[i];
        
        int end = Math.Min(nums.Length - 1, i + nums[i]);

        for(int j = end; j > i; j--)
        {
            if(DFS(j, nums, memo))
            {
                memo[j] = true;
                return true;
            }
        }

        memo[i] = false;
        return false;
    }
}
