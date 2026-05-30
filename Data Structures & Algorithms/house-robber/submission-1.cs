public class Solution 
{
    public int Rob(int[] nums) 
    {
        int rob1 = 0;
        int rob2 = 0;

        foreach(var num in nums)
        {
            int curr = Math.Max(rob1 + num, rob2);
            rob1 = rob2;
            rob2 = curr;
        }

        return rob2;
    }
}
