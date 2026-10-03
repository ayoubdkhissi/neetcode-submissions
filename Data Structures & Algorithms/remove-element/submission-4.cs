 

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var i = 0;
        var n = nums.Length;
        while(i < n)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[n - 1];
                n--;
            }
            else
                i++;
        }

        return n;
    }
}