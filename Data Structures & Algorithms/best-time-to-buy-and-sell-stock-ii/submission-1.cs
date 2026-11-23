public class Solution
{
	// the idea is to buy low, and hold while the price is increasing
	// we sell the day before the first drop. then we don't buy while it's dropping,
	// and we buy the day before it starts increasing again.
	public int MaxProfit(int[] prices)
	{
		var n = prices.Length;
		var profit = 0;
		var buyIndex = 0;
		var i = 1;

		var holding = false;
		while(i<n)
		{
			if(!holding)
			{
				while(i<n && prices[i] <= prices[i-1])
				{
					i++;
				}
				holding = true;
				buyIndex = i - 1;
			}
			else
			{
				while (i < n && prices[i] > prices[i - 1])
				{
					i++;
				}
				holding = false;
				profit +=  prices[i - 1] - prices[buyIndex];
				buyIndex = i;
			}
		}
		return profit;
	}
}