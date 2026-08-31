public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        Dictionary<int,int> map = new() { [0] = -1 };
        int curSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            curSum += nums[i];

            int remainder = curSum % k;

            if(map.ContainsKey(remainder) && (i - map[remainder]) >= 2)
                return true;
            
            if(!map.ContainsKey(remainder))
                map[remainder] = i;
        }

        return false;
    }
}