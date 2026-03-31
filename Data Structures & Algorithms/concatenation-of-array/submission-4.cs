public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int doubledLen = nums.Length * 2;
        int[] ans = new int[doubledLen];

        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = ans[i + nums.Length] = nums[i];
        }
        return ans;
    }
}