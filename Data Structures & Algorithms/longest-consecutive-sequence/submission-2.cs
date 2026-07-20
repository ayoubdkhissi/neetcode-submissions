public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        var n = nums.Length;
        var set = nums.ToHashSet();

        var count = 1;
        var ans = 1;

        for (int i = 0; i < n; i++)
        {
            if (!set.Contains(nums[i]-1))
            {
                for (int j = nums[i]+1; ; j++)
                {
                    if (set.Contains(j))
                        count++;
                    else
                    {
                        ans = Math.Max(ans, count);
                        count = 1;
                        break;
                    }
                }
            }
        }

        return ans;
    }
}
