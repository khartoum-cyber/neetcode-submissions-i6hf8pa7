public class Solution {
    private Dictionary<string, int> memo = new Dictionary<string, int>();

    public int Rob(int[] nums) 
    {
        if(nums.Length == 1)
            return nums[0];
        
        memo.Clear();
        int option1 = DFS(0, true, nums);
        memo.Clear();
        int option2 = DFS(1, false, nums);
        
        return Math.Max(option1, option2);
    }

    private int DFS(int i, bool flag, int[] nums)
    {
        if (i >= nums.Length || (flag && i == nums.Length - 1))
            return 0;

        string key = i + "-" + flag;
        if (memo.ContainsKey(key)) return memo[key];

        int res = Math.Max(DFS(i + 1, flag, nums), nums[i] + DFS(i + 2, flag, nums));
        return memo[key] = res;
    }
}