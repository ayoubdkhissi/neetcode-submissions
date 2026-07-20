public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
            
        nums = nums.OrderBy(x => x).ToArray();

        var count = 1;
        var ans = 0;
        for(int i=0; i< nums.Length-1; i++)
        {
            if (nums[i+1] == nums[i]+1)
            {
                count++;
            }
            else if (nums[i+1] == nums[i])
            {
                continue;
            }
            else
            {
                ans = Math.Max(ans, count);
                count = 1;
            }
        }

        return Math.Max(ans, count);
    }
}
