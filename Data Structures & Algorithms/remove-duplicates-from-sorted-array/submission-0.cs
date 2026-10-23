public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		var set = new HashSet<int>(nums);
		var i = 0;
		foreach(var x in set)
		{
			nums[i] = x;
			i++;
		}
		return set.Count;
	}
}