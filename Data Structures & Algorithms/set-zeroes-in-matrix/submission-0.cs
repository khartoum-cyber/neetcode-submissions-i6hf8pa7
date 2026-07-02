public class Solution 
{
    public void SetZeroes(int[][] matrix) 
    {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;

        bool[] rows = new bool[ROWS];
        bool[] cols = new bool[COLS];

        for(int i = 0; i < ROWS; i++)
        {
            for(int j = 0; j < COLS; j++)
            {
                if(matrix[i][j] == 0)
                {
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }

        for(int i = 0; i < ROWS; i++)
        {
            for(int j = 0; j < COLS; j++)
            {
                if(rows[i] == true || cols[j] == true)
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
