public class Solution 
{
    private int[,] dp;

    public int UniquePathsWithObstacles(int[][] obstacleGrid) 
    {
        if(obstacleGrid[0][0] == 1)
            return 0;

        int M = obstacleGrid.Length;
        int N = obstacleGrid[0].Length;

        dp = new int[M, N];
        for (int i = 0; i < M; i++) {
            for (int j = 0; j < N; j++) {
                dp[i, j] = -1;
            }
        }

        return DFS(0, 0, M, N, obstacleGrid);
    }

    private int DFS(int r, int c, int M, int N, int[][] obstacleGrid)
    {
        if(r == (M - 1) && c == (N - 1))
            return 1;
        
        if(r >= M || c >= N || obstacleGrid[r][c] == 1)
            return 0;

        if(dp[r, c] != -1)
            return dp[r, c];
        
        return dp[r, c] = DFS(r, c + 1, M, N, obstacleGrid) + DFS(r + 1, c, M, N, obstacleGrid);
    }
}