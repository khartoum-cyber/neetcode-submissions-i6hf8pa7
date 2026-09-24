public class Solution 
{
    public int[][] GenerateMatrix(int n) 
    {
        int[][] resMat = new int[n][];

        for(int i = 0; i < n; i++)
        {
            resMat[i] = new int[n];
        }

        int counter = 1;

        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        while(left <= right)
        {
            for(int i = left; i <= right; i++)
                resMat[top][i] = counter++;
            
            top++;

            if(top > bottom)
                break;

            for(int i = top; i <= bottom; i++)
                resMat[i][right] = counter++;
            
            right--;

            if(left > right)
                break;

            for(int i = right; i >= left; i--)
                resMat[bottom][i] = counter++;
            
            bottom--;

            for(int i = bottom; i >= top; i--)
                resMat[i][left] = counter++;
            
            left++;
        }

        return resMat;
    }
}