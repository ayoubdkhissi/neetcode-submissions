public class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var n = nums.Length;
		var map = new Dictionary<int, int>();

		for(int i=0; i<n; i++)
		{
			if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
				return true;
			else if (map.ContainsKey(nums[i]))
				map[nums[i]] = i;
			else
				map.Add(nums[i], i);
		}

		return false;
	}
}