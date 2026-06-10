public class Solution {
    private Dictionary<string, int> memo = new Dictionary<string, int>();

    public int LengthOfLIS(int[] nums) 
    {
        return DFS(nums, 0, -1);
    }

    private int DFS(int[] nums, int i, int j)
    {
        if(i == nums.Length)
            return 0;

        string key = $"{i},{j}";

        if (memo.ContainsKey(key)) 
            return memo[key];

        int lis = DFS(nums, i + 1, j);

        if(j == -1 || nums[j] < nums[i])
        {            
            lis = Math.Max(lis, 1 + DFS(nums, i + 1, i));
        }

        return memo[key] = lis;
    }
}