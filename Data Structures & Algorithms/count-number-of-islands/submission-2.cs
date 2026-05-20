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
                    BFS(grid, r, c, rows, cols);
                    islands++;
                }
            }
        }
        return islands;
    }

    private void BFS(char[][] grid, int startR, int startC, int rows, int cols)
    {
        Queue<(int row, int col)> q = new();
        grid[startR][startC] = '0';
        q.Enqueue((startR, startC));

        while(q.Count > 0)
        {
            var (currR, currC) = q.Dequeue();

            foreach(var dir in dirs)
            {
                int nr = currR + dir[0];
                int nc = currC + dir[1];

                if(nr >= 0 && nc >= 0 && nr < rows && nc < cols && grid[nr][nc] == '1')
                {
                    grid[nr][nc] = '0';
                    q.Enqueue((nr, nc));
                }
            }
        }
    }
}