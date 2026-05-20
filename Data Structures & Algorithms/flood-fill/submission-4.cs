public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        int startColor = image[sr][sc];
        if(startColor == color)
            return image;

        int rows = image.Length;
        int cols = image[0].Length;

        Queue<(int rows, int cols)> q = new();

        int[][] dirs = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 }
            };

        image[sr][sc] = color;
        q.Enqueue((sr, sc));

        while(q.Count > 0)
        {
            var (r, c) = q.Dequeue();

            foreach(var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = c + dir[1];

                if(nr >= 0 && nr < rows && nc >= 0 && nc < cols && image[nr][nc] == startColor)
                {
                    image[nr][nc] = color;
                    q.Enqueue((nr, nc));
                }
            }
        }

        return image;
    }
}