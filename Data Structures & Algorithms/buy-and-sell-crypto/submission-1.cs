public class Solution {
    public int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;
        var profit = 0;

        foreach (var currentPrice in prices)
        {
            minPrice = Math.Min(minPrice, currentPrice);
            profit = Math.Max(profit, currentPrice - minPrice);
        }
        return profit;
    }
}
