public class Solution 
{
    public double MyPow(double x, int n) 
    {
        long exp = n;
        if (exp < 0)
        {
            x = 1.0 / x;
            exp = -exp;
        }
        return FastPow(x, exp);
    }

    private double FastPow(double x, long n)
    {
        if (n == 0)
            return 1.0;

        double half = FastPow(x, n / 2);

        if (n % 2 == 0)
            return half * half;

        return half * half * x;
    }
}