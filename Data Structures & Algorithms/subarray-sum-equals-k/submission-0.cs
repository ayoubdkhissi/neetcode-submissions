public class Solution
{
	public int SubarraySum(int[] nums, int k)
	{
		var n = nums.Length;
		var preFixSum = new int[n];
		preFixSum[0] = nums[0];
		for (int i = 1; i < n; i++)
		{
			preFixSum[i] = preFixSum[i-1] + nums[i];
		}

		var count = 0;
		for(int i=0; i<n; i++)
		{
			for(int j = i; j<n; j++)
			{
				var sum = preFixSum[j] - (i == 0 ? 0 : preFixSum[i - 1]);
				if (sum == k)
				{
					count++;
				}
			}
		}

		return count;
	}
}