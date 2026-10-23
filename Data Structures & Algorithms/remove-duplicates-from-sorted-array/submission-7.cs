public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		short index = 0;
		for(int i=1; i<nums.Length; i++)
		{
			if (nums[i] != nums[index])
			{
				nums[++index] = nums[i];
			}
		}

		return index+1;
	}
}