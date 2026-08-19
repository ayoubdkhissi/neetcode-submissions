public class Solution {
    public int MaxArea(int[] heights)
    {
        var n = heights.Length;
        var l = 0;
        var r = n - 1;
        var ans = 0;
        while(l < r)
        {
            var amount = Math.Min(heights[l], heights[r]) * (r - l);
            ans = Math.Max(amount, ans);
            if (heights[l] > heights[r])
                r--;
            else
                l++;
        }

        return ans;

    }
}
