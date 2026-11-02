public class Solution
{
	public void SortColors(int[] nums)
	{
		var count = new int[3];
		foreach(var item in nums)
		{
			count[item]++;
		}

		var i = 0;
		for(int j=0; j<count.Length; j++)
		{
			for(int k=0; k<count[j]; k++ )
			{
				nums[i++] = j;
			}
		}
	}
}

