public class Solution 
{
    public int NumDecodings(string s) 
    {
        Dictionary<int,int> memo = new();

        memo[s.Length] = 1;

        return DFS(0);

        int DFS(int i)
        {
            if(memo.ContainsKey(i))
                return memo[i];

            if(s[i] == '0')
                return 0;
            
            int res = DFS(i + 1);

            if (i < s.Length - 1 && (s[i] == '1' || s[i] == '2' && s[i + 1] < '7')) 
            {
                res += DFS(i + 2);
            }

            memo[i] = res;

            return res;
        }
    }
}
