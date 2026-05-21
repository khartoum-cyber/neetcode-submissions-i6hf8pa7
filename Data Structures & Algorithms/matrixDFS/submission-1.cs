public class Solution 
{
    private readonly int[][] dirs = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };  

    public int CountPaths(int[][] grid) 
    {
        return DFS(grid, 0, 0, new HashSet<string>());
    }

    private int DFS(int[][] grid, int row, int col, HashSet<string> visited)
    {
        if(Math.Min(row, col) < 0 || row == grid.Length || col == grid[0].Length || 
            visited.Contains(row + "," + col) || grid[row][col] == 1)
            return 0;

        if(row == grid.Length - 1 && col == grid[0].Length - 1)
            return 1;

        visited.Add(row + "," + col);

        int count = 0;
        foreach(var dir in dirs)
        {
            count += DFS(grid, row + dir[0], col + dir[1], visited);
        }

        visited.Remove(row + "," + col);
        return count;
    }
}
