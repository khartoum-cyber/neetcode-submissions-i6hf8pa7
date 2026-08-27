public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int[] prefix = new int[nums.Length + 1];

        for(int i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        for(int index = 0; index < nums.Length; index++)
        {
            int leftSum = prefix[index];
            int rightSum = prefix[nums.Length] - prefix[index + 1];

            if(leftSum == rightSum)
                return index;
        }

        return -1;
    }
}