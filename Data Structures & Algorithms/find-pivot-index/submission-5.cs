public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int[] prefixSum = new int[nums.Length + 1];

        for(int i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = nums[i] + prefixSum[i];
        }


        for(int i = 0; i < nums.Length; i++)
        {
            int leftSum = prefixSum[i];
            int rightSum = prefixSum[nums.Length] - prefixSum[i + 1];

            if(rightSum == leftSum)
                return i;
        }

        return -1;
    }
}