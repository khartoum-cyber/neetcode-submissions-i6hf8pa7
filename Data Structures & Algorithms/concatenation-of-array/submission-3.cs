public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int numLength = nums.Length;
        int[] arr = new int [numLength * 2];

        for(int i = 0; i < numLength; i++)
        {
            arr[i] = arr[i + numLength] = nums[i];
        }

        return arr;
    }
}