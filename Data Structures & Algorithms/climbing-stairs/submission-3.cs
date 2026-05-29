public class Solution 
{
    public int ClimbStairs(int n) 
    {   
        int steps = 0;

        return DFS(n, steps, new Dictionary<int, int>());

        int DFS(int n, int steps, Dictionary<int, int> memo)
        {
            if(steps == n)
                return 1;

            if(steps > n)
                return 0;
            
            if(memo.ContainsKey(steps))
                return memo[steps];

            int result = DFS(n, steps + 1, memo) + DFS(n, steps + 2, memo);

            memo[steps] = result;

            return result;
        }
    }
}
