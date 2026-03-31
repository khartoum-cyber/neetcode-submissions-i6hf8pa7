public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        var numsLength = nums.Length;
        var ans = new int[numsLength*2];

        for (int i = 0; i < numsLength; i++)
        {
            ans[i] = nums [i];
            ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}