public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var cleanNums = nums.Where(x => x != val).ToArray();

        for(int i=0; i<cleanNums.Length; i++)
        {
            nums[i] = cleanNums[i];
        }
        return cleanNums.Length;
    }
}