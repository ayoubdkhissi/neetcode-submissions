public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        return Enumerable.Concat(nums, nums).ToArray();
    }
}