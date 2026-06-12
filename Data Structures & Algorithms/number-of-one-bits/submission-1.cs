public class Solution 
{
    public int HammingWeight(uint n) 
    {
        int res = 0;

        for(int i = 0; i < 32; i++)
        {
            var mask = 1 << i;

            if((mask & n) != 0)
                res++;
        }

        return res;
    }
}
