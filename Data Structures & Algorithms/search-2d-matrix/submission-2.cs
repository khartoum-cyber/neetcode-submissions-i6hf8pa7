public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int l = 0;
        int r = rows * cols - 1;

        while(l <= r)
        {
            int mid = (l + r) / 2;

            int row = mid / cols;
            int col = mid % cols;

            if (matrix[row][col] == target)
                return true;
            else if(matrix[row][col] < target)
                l = mid + 1;
            else
                r = mid - 1;
        }
        return false;
    }
}
