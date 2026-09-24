public class Solution 
{
    public void SetZeroes(int[][] matrix) 
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        bool[] brows = new bool[rows];
        bool[] bcols = new bool[cols];

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(matrix[r][c] == 0)
                {
                    brows[r] = true;
                    bcols[c] = true;
                }
            }
        }

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(brows[r] == true || bcols[c] == true)
                    matrix[r][c] = 0;
            }
        }
    }
}
