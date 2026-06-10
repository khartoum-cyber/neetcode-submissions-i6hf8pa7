public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {
        Dictionary<int,int> memo = new();

        int minCoins = DFS(coins, amount, memo);

        return (minCoins >= 1e9) ? -1 : minCoins;
    }

    private int DFS(int[] coins, int amount, Dictionary<int,int> memo)
    {
        if(amount == 0)
            return 0;

        if(memo.ContainsKey(amount))
            return memo[amount];
        
        int res = (int)1e9;

        foreach(var coin in coins)
        {
            if(amount - coin >= 0)
            {
                res = Math.Min(res, 1 + DFS(coins, amount - coin, memo));
                memo[amount] = res;
            }
        }

        return res;
    }
}
