public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        Dictionary<int,int> prefixMap = new() { [0] = -1};

        int total = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            total += nums[i];

            int remainder = total % k;

            if(prefixMap.ContainsKey(remainder))
            {
                if((i - prefixMap[remainder]) > 1)
                    return true;
            }
            else
                prefixMap[remainder] = i;
        }

        return false;
    }
}