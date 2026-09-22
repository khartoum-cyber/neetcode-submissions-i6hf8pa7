public class Solution 
{
    public int DiagonalSum(int[][] mat) 
    {
        int n = mat.Length;
        int res = 0;

        for(int r = 0; r < n; r++)
        {
            for(int c = 0; c < n; c++)
            {
                if(r == c)
                    res += mat[r][c];
                
                if(r + c == n - 1 && r != c)
                    res += mat[r][c];
            }
        }

        return res;
    }
}