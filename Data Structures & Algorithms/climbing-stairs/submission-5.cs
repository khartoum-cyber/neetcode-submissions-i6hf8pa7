public class Solution 
{
    //Space optimized
    public int ClimbStairs(int n) 
    {     
        if (n <= 1)
            return 1;

        int next1 = 1;
        int next2 = 1;

        for(int i = 2; i <= n; i++)
        {
            int curr = next1 + next2;
            next2 = next1;
            next1 = curr;
        }

        return next1;
    }
}
