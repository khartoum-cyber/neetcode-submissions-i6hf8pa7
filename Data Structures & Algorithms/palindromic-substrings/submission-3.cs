public class Solution 
{
    public int CountSubstrings(string s) 
    {
        int n = s.Length;
        bool?[,] memo = new bool?[n, n];

        int count = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                if(DFS(i, j, s, memo))
                    count++;
            }
        }

        return count;
    }

    private bool DFS(int l, int r, string s, bool?[,] memo)
    {
        if(l >= r)
            return true;
        
        if(memo[l, r] != null)
            return memo[l, r].Value;

        if(s[l] != s[r])
        {
            memo[l, r] = false;
            return false;
        }
        
        memo[l, r] = DFS(l + 1, r - 1, s, memo);
        return memo[l, r].Value;
    }
}