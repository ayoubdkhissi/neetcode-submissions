public class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var n = nums.Length; if (n == 1) return false;
		var set = new HashSet<int>(nums.Take(k+1));
		if (set.Count < k + 1)
			return true;
		for(int i=0; i<n-k-1; i++)
		{
			set.Remove(nums[i]);
			set.Add(nums[i + k + 1]);
			if (set.Count < k + 1)
				return true;
		}

		return false;
	}
}