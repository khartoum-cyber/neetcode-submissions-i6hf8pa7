public class Solution {
    public List<List<int>> Permute(int[] nums) 
    {
        var res = new List<List<int>>();
        var subset = new List<int>();
        Dfs(nums, new bool[nums.Length], subset, res);
        return res;
    }

    private void Dfs(int[] nums, bool[] used, List<int> subset, List<List<int>> res)
    {
        if(subset.Count == nums.Length)
        {
            res.Add(new List<int>(subset));
            return;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(!used[i])
            {
                used[i] = true;
                subset.Add(nums[i]);
                Dfs(nums, used, subset, res);
                subset.RemoveAt(subset.Count - 1);
                used[i] = false;
            }
        }
    }
}
