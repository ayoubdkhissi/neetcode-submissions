public class Solution {
    public int MaxProfit(int[] prices) 
    {
        var n = prices.Length;
        var buy_at = prices[0];
        var profit = 0;
        for (int i = 1; i < n; i++)
        {
            if (prices[i] < buy_at)
            {
                buy_at = prices[i];
            }

            profit = Math.Max(prices[i] - buy_at, profit);
        }


        return profit ;

    }
}
