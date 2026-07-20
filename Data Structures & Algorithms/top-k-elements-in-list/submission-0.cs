public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count())
            .OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
    }
}
