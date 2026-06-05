public class Solution {
    public int Rob(int[] nums) 
    {
        if(nums.Length == 1)
            return nums[0];

        int[] arr = new int[nums.Length];

        arr[0] = nums[0];
        arr[1] = Math.Max(arr[0], nums[1]);

        for(int i = 2; i < nums.Length; i++)
        {
            arr[i] = Math.Max(arr[i - 1], arr[i - 2] + nums[i]);
        }

        return Math.Max(arr[nums.Length - 1], arr[nums.Length - 2]);
    }
}
