public class Solution
{
	public void SortColors(int[] nums)
	{
		if (nums.Length <= 1)
			return;

		var mid = nums.Length / 2;
		var left = nums[..mid];
		var right = nums[mid..];

		SortColors(left);
		SortColors(right);

		Merge(nums, left, right);
	}

	private void Merge(int[] nums, int[] left, int[] right)
	{
		var i = 0;
		var j = 0;
		var k = 0;

		while(i < left.Length && j < right.Length)
		{
			if (left[i] < right[j])
				nums[k++] = left[i++];
			else
				nums[k++] = right[j++];
		}

		while(i<left.Length)
		{
			nums[k++] = left[i++];
		}

		while(j<right.Length)
		{
			nums[k++] = right[j++];
		}
	}
}

