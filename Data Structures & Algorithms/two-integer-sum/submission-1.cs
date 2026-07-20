public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
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
            if (map.ContainsKey(target - nums[i]))
            {
                var indices = map[target - nums[i]];
                if (indices.Count > 1)
                    return [indices[0], indices[1]];
                else if (indices[0] != i)
                    return [i, indices[0]];
            }
        }
        return [];
    }
}
