public class Solution 
{
    public int LongestCommonSubsequence(string text1, string text2) 
    {
        int[,] memo = new int[text1.Length, text2.Length];
        for (int i = 0; i < text1.Length; i++) {
            for (int j = 0; j < text2.Length; j++) {
                memo[i, j] = -1;
            }
        }

        return DFS(0, 0, text1, text2, memo);
    }

    private int DFS(int i, int j, string text1, string text2, int[,] memo)
    {
        if(i >= text1.Length || j >= text2.Length)
            return 0;

        if(memo[i, j] != -1)
            return memo[i, j];
        
        if(text1[i] == text2[j])
        {
            memo[i, j] = 1 + DFS(i + 1, j + 1, text1, text2, memo);
        }
        else
        {
            memo[i, j] = Math.Max(DFS(i + 1, j, text1, text2, memo), DFS(i, j + 1, text1, text2, memo));
        }

        return memo[i, j];
    }
}
