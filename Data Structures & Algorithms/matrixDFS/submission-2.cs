public class Solution 
{
    public int CountPaths(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if(grid[0][0] == 1 || grid[rows - 1][cols - 1] == 1)
            return 0;

        return DFS(grid, 0, 0, rows, cols, new HashSet<string>());
    }

    private int DFS(int[][] grid, int r, int c, int rows, int cols, HashSet<string> visited)
    {
        if(Math.Min(r, c) < 0 || r == rows || c == cols || 
            visited.Contains(r + "," + c) || grid[r][c] == 1)
            return 0;
        
        if(r == rows - 1 && c == cols - 1)
            return 1;

        visited.Add(r + "," + c);
        
        int count = 0;
        count += DFS(grid, r + 1, c, rows, cols, visited);
        count += DFS(grid, r - 1, c, rows, cols, visited);
        count += DFS(grid, r, c + 1, rows, cols, visited);
        count += DFS(grid, r, c - 1, rows, cols, visited);

        visited.Remove(r + "," + c);

        return count;
    }
}
