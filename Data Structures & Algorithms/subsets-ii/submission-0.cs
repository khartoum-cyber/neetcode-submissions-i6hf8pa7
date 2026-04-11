public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) 
    {
        var res = new List<List<int>>();

        Array.Sort(nums);
        Backtrack(0, new List<int>());

        return res;

        void Backtrack(int start, List<int> subset)
        {
            res.Add(new List<int>(subset));

            for(int i = start; i < nums.Length; i++)
            {
                if(i > start && nums[i] == nums[i - 1])
                    continue;

                subset.Add(nums[i]);
                Backtrack(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
