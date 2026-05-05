public class Solution {
    public int ShortestPath(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if(grid[0][0] == 1 || grid[rows - 1][cols - 1] == 1)
            return -1;

        int[][] dirs = new int[][]
            {
                new int[] { 1, 0 }, 
                new int[] { -1, 0 }, 
                new int[] { 0, 1 }, 
                new int[] { 0, -1 }
            };

        Queue<(int r, int c, int dist)> q = new();

        grid[0][0] = 1;
        q.Enqueue((0, 0, 0));

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