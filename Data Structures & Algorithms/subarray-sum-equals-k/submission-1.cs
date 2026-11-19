public class Solution
{
	public int SubarraySum(int[] nums, int k)
	{
		var n = nums.Length;
		var preFixSums = new Dictionary<int, int>();
		var count = 0;
		var currSum = 0;
		preFixSums[0] = 1;

		foreach(var num in nums)
		{
			currSum += num;
			var diff = currSum - k;
			if (preFixSums.ContainsKey(diff))
				count += preFixSums[diff];
			if (!preFixSums.ContainsKey(currSum))
				preFixSums[currSum] = 0;

			preFixSums[currSum]++;
		}

		return count;
	}
}