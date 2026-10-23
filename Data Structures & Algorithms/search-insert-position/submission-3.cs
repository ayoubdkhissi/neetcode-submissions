public class Solution
{
	public int SearchInsert(int[] nums, int target)
	{

		var l = 0;
		var r = nums.Length - 1;
		var res = nums.Length;
		while (l <= r)
		{
			var mid = (l + r) / 2;
			if (nums[mid] == target)
				return mid;

			else if (nums[mid] < target)
				l = mid + 1;

			else
			{
				r = mid - 1;
				res = mid;
			}
		}

		return res;
	}
}