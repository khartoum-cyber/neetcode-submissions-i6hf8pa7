public class Solution 
{
    public int SubarraysDivByK(int[] nums, int k) 
    {
        Dictionary<int,int> prefixSum = new() { [0] = 1 };
        int res = 0;
        int curSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            curSum += nums[i];
            int remainder = curSum % k;

            if(prefixSum.ContainsKey(remainder))
                res += prefixSum[remainder];
            
            if(!prefixSum.ContainsKey(remainder))
                prefixSum[remainder] = 1;
            else
                prefixSum[remainder]++;
        }

        return res;
    }
}