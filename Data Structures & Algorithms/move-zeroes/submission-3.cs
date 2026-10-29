public class Solution
{
	public void MoveZeroes(int[] nums)
	{
		var i = 0;

		while (i< nums.Length && nums[i] != 0)
			i++;
		var j = i;
		while (j<nums.Length)
		{
			if (nums[j] != 0)
			{
				nums[i] = nums[j];
				nums[j] = 0;
				while (i < j &&  nums[i] != 0)
					i++;
			}
			j++;
		}
	}
}