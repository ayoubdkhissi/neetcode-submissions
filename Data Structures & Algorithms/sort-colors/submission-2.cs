public class Solution
{
	public void SortColors(int[] nums)
	{
		int l = 0, r = nums.Length - 1, i = 0;

		while(i <= r)
		{
			if (nums[i] == 0)
			{
				nums[i++] = nums[l];
				nums[l++] = 0;
			}
			else if (nums[i] == 2)
			{
				nums[i] = nums[r];
				nums[r--] = 2;
			}
			else
				i++;
		}
	}
}
