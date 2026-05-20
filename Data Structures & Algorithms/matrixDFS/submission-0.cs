public class Solution {
    public int CountPaths(int[][] grid) 
    {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;
        return DFS(grid, 0, 0, new HashSet<string>());
    }

    private int DFS(int[][] grid, int r, int c, HashSet<string> visited)
    {
        if(Math.Min(r, c) < 0 || r == grid.Length || c == grid[0].Length || 
            visited.Contains(r + "," + c) || grid[r][c] == 1)
            return 0;
        
        if(r == grid.Length - 1 && c == grid[0].Length - 1)
            return 1;

        visited.Add(r + "," + c);

        int count = 0;
        count += DFS(grid, r + 1, c, visited);
        count += DFS(grid, r - 1, c, visited);
        count += DFS(grid, r, c + 1, visited);
        count += DFS(grid, r, c - 1, visited);

        visited.Remove(r + "," + c);

        return count;
    }
}
