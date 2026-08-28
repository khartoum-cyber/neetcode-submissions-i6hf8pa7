public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int[] prefix = new int[nums.Length + 1];

        for(int i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        for(int i = 0; i < nums.Length; i++)
        {
            int leftSum = prefix[i];
            int rightSum = prefix[nums.Length] - prefix[i + 1];

            if(leftSum == rightSum)
                return i;
        }

        return -1;
    }
}