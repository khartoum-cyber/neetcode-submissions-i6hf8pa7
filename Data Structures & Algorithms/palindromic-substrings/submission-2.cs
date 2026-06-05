public class Solution {
    public int CountSubstrings(string s) 
    {
        int n = s.Length;

        int count = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                if(DFS(i, j, s))
                    count++;
            }
        }

        return count;
    }

    private bool DFS(int l, int r, string s)
    {
        if(l >= r)
            return true;
        
        if(s[l] != s[r])
            return false;
        
        return DFS(l + 1, r - 1, s);
    }
}