public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if(map.TryGetValue(diff, out int j))
                return new[] {j, i};
            
            if(!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
