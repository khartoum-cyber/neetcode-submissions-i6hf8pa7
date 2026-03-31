public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int newLength = nums.Length * 2;
        int[] ans = new int [newLength];

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}