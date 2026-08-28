public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int total = 0;

        foreach(var num in nums)
        {
            total += num;
        }

        int leftSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int rightSum = total - leftSum - nums[i];

            if(leftSum == rightSum)
                return i;
            
            leftSum += nums[i];
        }

        return -1;
    }
}