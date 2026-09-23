public class Solution 
{
    public List<int> SpiralOrder(int[][] matrix) 
    {

        List<int> res = new();

        int left = 0;
        int right = matrix[0].Length;
        int top = 0;
        int bottom = matrix.Length;

        while(left < right && top < bottom)
        {
            for(int r = left; r < right; r++)
            {
                res.Add(matrix[top][r]);
            }
            top++;

            for(int d = top; d < bottom; d++)
            {
                res.Add(matrix[d][right - 1]);
            }
            right--;

            if(!(left < right && top < bottom))
                break;
            
            for(int b = right - 1; b >= left; b--)
            {
                res.Add(matrix[bottom - 1][b]);
            }
            bottom--;

            for(int u = bottom - 1; u >= top; u--)
            {
                res.Add(matrix[u][left]);
            }
            left++;
        }

        return res;
    }
}
