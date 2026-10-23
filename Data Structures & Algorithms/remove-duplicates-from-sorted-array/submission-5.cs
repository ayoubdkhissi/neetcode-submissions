public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		var index = 0;
		var lastValue = nums[0];
		for(int i=1; i<nums.Length; i++)
		{
			if (nums[i] != lastValue)
			{
				nums[++index] = nums[i];
				lastValue = nums[i];
			}
		}

		return index+1;
	}
}