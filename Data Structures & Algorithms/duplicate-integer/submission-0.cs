public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();

        foreach (var x in nums)
        {
            if (set.Contains(x))
                return true;
            set.Add(x);
        }
        return false;
    }
}