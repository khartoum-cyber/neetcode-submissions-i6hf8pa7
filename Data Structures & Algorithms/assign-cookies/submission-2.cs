public class Solution 
{
    public int FindContentChildren(int[] g, int[] s) 
    {
        Array.Sort(g);
        Array.Sort(s);

        int i = 0, j = 0;

        while(i < s.Length && j < g.Length)
        {
            if(s[i] >= g[j])
                j++;
            
            i++;
        }

        return j;
    }
}