public class Solution {
    // public bool SearchMatrix(int[][] matrix, int target) 
    // {
    //     int rows = matrix.Length;
    //     int cols = matrix[0].Length;
    //     int left = 0;
    //     int right = rows * cols - 1;

    //     while(left <= right)
    //     {
    //         int mid = left + (right - left) / 2;
    //         int midValue = matrix[mid / cols][mid % cols];

    //         if(midValue == target)
    //             return true;

    //         if(midValue < target)
    //             left = mid + 1;
    //         else
    //             right = mid - 1;
    //     } 

    //     return false;
    // }

    public bool SearchMatrix(int[][] matrix, int target) 
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == target)
                    return true;
            }
        }
        return false;
    }
}
