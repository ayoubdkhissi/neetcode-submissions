public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        var n = nums.Length;
        var ans = new List<List<int>>();
        var map = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]].Add(i);
            else
                map.Add(nums[i], [i]);
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (map.ContainsKey(-nums[i] - nums[j]) &&
                    map[-nums[i] - nums[j]].Any(x => x != i && x != j))
                {
                    ans.Add([nums[i], nums[j], -nums[i] - nums[j]]);
                }
            }
        }

        for(int i=0; i<ans.Count; i++)
        {
            ans[i] = ans[i].OrderBy(x => x).ToList();
        }

        ans = ans.Select(x => (x[0], x[1], x[2]))
            .DistinctBy(x => (x.Item1, x.Item2, x.Item3))
            .Select(x => new List<int>() { x.Item1, x.Item2, x.Item3})
            .ToList();
        return ans;

    }
}
