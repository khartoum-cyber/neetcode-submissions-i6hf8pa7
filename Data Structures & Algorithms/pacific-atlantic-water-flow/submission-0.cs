public class Solution 
{
    private readonly int[][] dirs = new int[][] 
    {
        new int[] { 1, 0 }, 
        new int[] { -1, 0 },
        new int[] { 0, 1 }, 
        new int[] { 0, -1 }
    };

    public List<List<int>> PacificAtlantic(int[][] heights) 
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[,] pac = new bool[rows, cols];
        bool[,] atl = new bool[rows, cols];

        for(int c = 0; c < cols; c++)
        {
            DFS(0, c, pac, heights);
            DFS(rows - 1, c, atl, heights);
        }

        for(int r = 0; r < rows; r++)
        {
            DFS(r, 0, pac, heights);
            DFS(r, cols - 1, atl, heights);
        }

        List<List<int>> res = new();
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(pac[r,c] && atl[r,c])
                {
                    res.Add(new List<int> { r,c });
                }
            }
        }

        return res;
    }

    private void DFS(int r, int c, bool[,] ocean, int[][] heights)
    {
        ocean[r, c] = true;

        foreach(var dir in dirs)
        {
            int nr = r + dir[0];
            int nc = c + dir[1];

            if(nr >= 0 && nr < heights.Length && nc >= 0 &&
                nc < heights[0].Length && !ocean[nr, nc] &&
                heights[nr][nc] >= heights[r][c])
                {
                    DFS(nr, nc, ocean, heights);
                }
        }
    }
}
