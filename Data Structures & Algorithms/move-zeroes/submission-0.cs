public class Solution
{
	public void MoveZeroes(int[] nums)
	{
		var list = nums.Where(x => x != 0).ToList();
		for(int i=0; i<list.Count; i++)
		{
			nums[i] = list[i];
		}
		for(int i=list.Count; i<nums.Length; i++)
		{
			nums[i] = 0;
		}
	}
}