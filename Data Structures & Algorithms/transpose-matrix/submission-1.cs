public class Solution 
{
    public int[][] Transpose(int[][] matrix) 
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int[][] resMat = new int[cols][];

        for(int i = 0; i < cols; i++)
        {
            resMat[i] = new int[rows];
        }

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                resMat[c][r] = matrix[r][c];
            }
        }

        return resMat;
    }
}