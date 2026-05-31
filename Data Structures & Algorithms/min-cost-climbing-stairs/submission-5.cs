public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        int[] arr = new int[cost.Length];

        arr[0] = cost[0];
        arr[1] = cost[1];

        for(int i = 2; i < cost.Length; i++)
        {
            arr[i] = Math.Min(arr[i - 1], arr[i - 2]) + cost[i];
        }

        return Math.Min(arr[cost.Length - 1], arr[cost.Length - 2]);
    }
}
