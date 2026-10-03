public class Solution {
    public int MajorityElement(int[] nums)
    {

        return nums.GroupBy(x => x)
                    .MaxBy(x => x.Count()).Key;

    }
}