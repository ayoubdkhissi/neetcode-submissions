public class Solution
{
	public void Rotate(int[] nums, int k)
	{
		var n = nums.Length;
		var tmp = new int[n];
		for(int i=0; i<n; i++)
		{
			tmp[(i + k) % n] = nums[i];
		}
		for(int i=0; i<n; i++)
		{
			nums[i] = tmp[i];
		}
	}
}