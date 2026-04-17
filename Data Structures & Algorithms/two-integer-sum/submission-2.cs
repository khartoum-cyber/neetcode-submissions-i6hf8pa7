public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> map = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];

            if(map.TryGetValue(compliment, out int j))
                return new int[] {j, i};
            
            if(!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
