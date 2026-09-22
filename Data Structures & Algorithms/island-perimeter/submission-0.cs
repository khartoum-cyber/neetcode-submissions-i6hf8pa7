public class Solution 
{
    public int IslandPerimeter(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int res = 0;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                {
                    if(r + 1 >= rows || grid[r + 1][c] == 0)
                        res++;
                    if(c + 1 >= cols || grid[r][c + 1] == 0)
                        res++;
                    if(r - 1 < 0 || grid[r - 1][c] == 0)
                        res++;
                    if(c - 1 < 0 || grid[r][c - 1] == 0)
                        res++;
                }
            }
        }

        return res;
    }
}