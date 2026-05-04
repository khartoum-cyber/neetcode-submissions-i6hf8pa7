public class Solution {
    public int OrangesRotting(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int freshOranges = 0;
        Queue<(int r, int c)> q = new();

        for(int r = 0; r < rows; r++)
        { 
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                {
                    freshOranges++;
                }
                else if(grid[r][c] == 2)
                {
                    q.Enqueue((r, c));
                }
            }
        }

        if(freshOranges == 0)
            return 0;

        int[][] dirs = new int[][]
        {
            new int[] { 0,  1 },  // right
            new int[] { 0, -1 },  // left
            new int[] { 1,  0 },  // down
            new int[] { -1, 0 }  // up
        };

        int minutes = 0;

        while(q.Count > 0)
        {
            int size = q.Count;
            bool rottedThisMinute = false;

            for(int i = 0; i < size; i++)
            {
                var (r, c) = q.Dequeue();

                foreach(var dir in dirs)
                { 
                    int nr = r + dir[0];
                    int nc = c + dir[1];

                    if (nr >= 0 && nr < rows &&
                        nc >= 0 && nc < cols &&
                        grid[nr][nc] == 1)
                        {
                            grid[nr][nc] = 2;
                            freshOranges--;
                            q.Enqueue((nr, nc));
                            rottedThisMinute = true;
                        }
                }
            }

            if(rottedThisMinute)
                minutes++;
        }

        return freshOranges == 0 ? minutes : -1;
    }
}