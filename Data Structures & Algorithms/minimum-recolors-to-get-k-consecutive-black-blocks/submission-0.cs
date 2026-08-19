public class Solution 
{
    public int MinimumRecolors(string blocks, int k) 
    {
        int n = blocks.Length;
        int w = 0;

        for(int i = 0; i < k; i++)
        {
            if(blocks[i] == 'W')
                w++;
        }

        int ans = w;

        for(int i = k; i < n; i++)
        {
            if(blocks[i] == 'W')
                w++;
            if(blocks[i - k] == 'W')
                w--;
            
            ans = Math.Min(ans, w);
        }

        return ans;
    }
}