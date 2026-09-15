public class Solution 
{
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int l = 1;
        int r = piles.Max();
        int res = r;

        while(l < r)
        {
            int k = l + (r - l) / 2;
            double hours = 0;

            foreach(var pile in piles)
            {
                hours += Math.Ceiling((double)pile / k);
            }

            if(hours <= h)
            {
                res = Math.Min(res, k);
                r = k;
            }
            else
            {
                l = k + 1;
            }
        }

        return res;
    }
}
