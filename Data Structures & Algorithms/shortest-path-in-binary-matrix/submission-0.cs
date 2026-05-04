public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if(grid[0][0] == 1 || grid[rows - 1][cols - 1] == 1)
            return -1;

        int[][] dirs = new int[][]
        {
            new int[] { 0,  1 },  // right
            new int[] { 0, -1 },  // left
            new int[] { 1,  0 },  // down
            new int[] { -1, 0 },  // up
            new int[] { 1,  1 },  // down-right
            new int[] { 1, -1 },  // down-left
            new int[] { -1, 1 },  // up-right
            new int[] { -1, -1 }  // up-left
        };

        Queue<(int row, int col, int dist)> q = new();

        grid[0][0] = 1;
        q.Enqueue((0, 0, 1));

        while(q.Count > 0)
        {
            var (r, c, dist) = q.Dequeue();

            if(r == rows - 1 && c == cols - 1)
                return dist;

            foreach(var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = c + dir[1];

                if(nr >= 0 && nr < rows && nc >= 0 && nc < cols && grid[nr][nc] == 0)
                {
                    grid[nr][nc] = 1;
                    q.Enqueue((nr, nc, dist + 1));
                }
            }
        }

        return -1;
    }
}