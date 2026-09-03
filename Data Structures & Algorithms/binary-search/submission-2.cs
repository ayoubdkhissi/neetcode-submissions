public class Solution {
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var mid = (l + r + 1) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid;
            }
        }
        return nums[0] != target ? -1 : 0;
    }
}
