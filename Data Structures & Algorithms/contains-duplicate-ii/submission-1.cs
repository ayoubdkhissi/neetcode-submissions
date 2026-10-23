public class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{

		for(int i=0; i<nums.Length-k; i++ )
		{
			var window = nums.Skip(i).Take(k + 1);
			if (window.Distinct().Count() < k + 1)
				return true;
		}
		if (k >= nums.Length && nums.Distinct().Count() < nums.Length)
			return true;

		return false;
	}
}