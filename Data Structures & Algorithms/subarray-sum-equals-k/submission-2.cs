public class Solution 
{
    public int SubarraySum(int[] nums, int k) 
    {
        Dictionary<int,int> prefixSums = new() { [0] = 1};

        int res = 0;
        int curSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            curSum += nums[i];

            int diff = curSum - k;

            if(prefixSums.ContainsKey(diff))
                res += prefixSums[diff];
            
            if(!prefixSums.ContainsKey(curSum))
                prefixSums[curSum] = 1;
            else
                prefixSums[curSum]++;
        }

        return res;
    }
}