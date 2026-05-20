public class Solution 
{
    private static readonly int[][] dirs = new int[][] 
    {
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, 1},
        new int[] {0, -1}
    };
    
    public int NumIslands(char[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == '1')
                {
                    DFS(grid, r, c, rows, cols);
                    islands++;
                }
            }
        }

        return islands;
    }

    private void DFS(char[][] grid, int r, int c, int rows, int cols)
    {
        if(r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
            return;

        grid[r][c] = '0';

        foreach(var dir in dirs)
        {
            int nr = r + dir[0];
            int nc = c + dir[1];

            DFS(grid, nr, nc, rows, cols);
        }
    }
}
