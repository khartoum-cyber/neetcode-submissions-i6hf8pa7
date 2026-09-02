public class NumMatrix 
{
    private readonly int[][] copy;

    public NumMatrix(int[][] matrix) 
    {
        copy = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) 
    {
        int res = 0;

        for(int r = row1; r <= row2; r++)
        {
            for(int c = col1; c <= col2; c++)
            {
                res += copy[r][c];
            }
        }

        return res;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */