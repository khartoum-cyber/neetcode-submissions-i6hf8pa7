public class Solution 
{
    public List<List<int>> CombinationSum(int[] nums, int target) 
    {
        var res = new List<List<int>>();
        var subset = new List<int>();
        RecCombinationSum(nums, 0, target, subset, res);
        return res;
    }

    private void RecCombinationSum(int[] nums, int i, int target, List<int> subset, List<List<int>> res)
    {
        if(target == 0)
        {
            res.Add(new List<int>(subset));
            return;
        }

        if(i == nums.Length || target < 0)
        {
            return;
        }

        subset.Add(nums[i]);
        RecCombinationSum(nums, i, target - nums[i], subset, res);
        subset.RemoveAt(subset.Count - 1);

        RecCombinationSum(nums, i + 1, target, subset, res);
    }
}
