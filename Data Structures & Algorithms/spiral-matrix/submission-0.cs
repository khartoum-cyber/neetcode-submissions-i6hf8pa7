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
            for(int i = left; i < right; i++)
                res.Add(matrix[top][i]);
            
            top++;

            for(int i = top; i < bottom; i++)
                res.Add(matrix[i][right - 1]);
            
            right--;

            if(!(left < right && top < bottom))
                break;

            for(int i = right - 1; i >= left; i--)
                res.Add(matrix[bottom - 1][i]);
            
            bottom--;

            for(int i = bottom - 1; i >= top; i--)
                res.Add(matrix[i][left]);
            
            left++;
         }

         return res;
    }
}
