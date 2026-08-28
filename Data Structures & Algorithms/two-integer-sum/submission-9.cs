public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> map = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(map.TryGetValue(complement, out int j))
                return new int[] {j, i};
            
            if(!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        return new int[0];
    }
}
