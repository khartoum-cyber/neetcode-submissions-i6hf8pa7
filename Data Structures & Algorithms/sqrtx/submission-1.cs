public class Solution 
{
    public int MySqrt(int x) 
    {
        int l = 0;
        int r = x;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;
            long square = (long)mid * mid;

            if(square < x)
                l = mid + 1;
            else if(square > x)
                r = mid - 1;
            else
                return mid;
        }

        return r;
    }
}