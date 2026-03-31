public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int l = 0;
        int r = 1;
        int profit = 0;

        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
            {
                int curr = prices[r] - prices[l];
                profit = Math.Max(profit, curr);
            }
            else
                l = r;
                
            r++;
        }
        return profit;
    }
}
