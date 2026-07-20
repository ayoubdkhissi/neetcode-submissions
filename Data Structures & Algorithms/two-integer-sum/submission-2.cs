public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, List<int>>();
        for (int i = nums.Length - 1; i >= 0 ; i--)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], [i]);
                continue;
            }
            map[nums[i]].Add(i);
        }

        for(int i = 0; i<nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]) && map[target - nums[i]][0] != i)
            {
                    return [i, map[target - nums[i]][0]];
            }
        }
        return [];
    }
}
