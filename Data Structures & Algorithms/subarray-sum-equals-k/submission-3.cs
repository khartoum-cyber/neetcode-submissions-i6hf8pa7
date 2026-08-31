public class Solution 
{
    public int SubarraySum(int[] nums, int k) 
    {
        Dictionary<int,int> prefixSum = new() { [0] = 1 };
        int res = 0;
        int curSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            curSum += nums[i];
            int diff = curSum - k;

            if(prefixSum.ContainsKey(diff))
                res += prefixSum[diff];
            
            if(!prefixSum.ContainsKey(curSum))
                prefixSum[curSum] = 1;
            else
                prefixSum[curSum]++;
        }

        return res;
    }
}