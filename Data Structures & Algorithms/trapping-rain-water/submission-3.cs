public class Solution {
    public int Trap(int[] height)
    {
        var n = height.Length;
        var sum = 0;
        var l = 0;
        var r = n - 1;
        var max_left = 0 ;
        var max_right = 0;

        while(l < r)
        {
            max_left = Math.Max(max_left, height[l]);
            max_right = Math.Max(max_right, height[r]);
            if (height[l] < height[r])
            {
                sum += Math.Min(max_left, max_right) - height[l] < 0 ? 0 : Math.Min(max_left, max_right) - height[l];
                l++;
            }
            else
            {
                sum += Math.Min(max_left, max_right) - height[r] < 0 ? 0 : Math.Min(max_left, max_right) - height[r];
                r--;
            }
        }

        return sum;
    }
}
    