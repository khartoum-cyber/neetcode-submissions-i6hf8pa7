public class Solution 
{
    public bool WordBreak(string s, List<string> wordDict) 
    {
        Dictionary<int,bool> memo = new Dictionary<int, bool>() { { s.Length, true } };

        return DFS(0, s, wordDict, memo);
    }

    private bool DFS(int i, string s, List<string> wordDict, Dictionary<int,bool> memo)
    {
        if(memo.ContainsKey(i))
            return memo[i];

        foreach(var word in wordDict)
        {            
            if(i + word.Length <= s.Length && word == s.Substring(i, word.Length))
            {
                if(DFS(i + word.Length, s, wordDict, memo))
                {
                    memo[i] = true;
                    return true;
                }
            }
        }

        memo[i] = false;
        return false;
    }
}
