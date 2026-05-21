public class Solution {
    public int ShortestPath(int[][] grid) 
    {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        if(grid[0][0] == 1 || grid[ROWS - 1][COLS - 1] == 1)
            return -1;
        
        int[][] dirs = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };   

        Queue<(int row, int col, int dist)> q = new();

        grid[0][0] = 1;
        q.Enqueue((0, 0, 0));

        while(q.Count > 0)
        {
            var (r, c, dist) = q.Dequeue();

            if(r == ROWS -1 && c == COLS -1)
                return dist;

            foreach(var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = c + dir[1];

                if(nr >= 0 && nr < ROWS && nc >= 0 && nc < COLS && grid[nr][nc] == 0)
                {
                    grid[nr][nc] = 1;
                    q.Enqueue((nr, nc, dist + 1));
                }
            }
        }

        return -1;
    }
}
