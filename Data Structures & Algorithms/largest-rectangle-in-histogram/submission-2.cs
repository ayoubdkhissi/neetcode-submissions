public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        var n = heights.Length;
        var stack = new Stack<(int h, int index)>([(heights[0], 0)]);
        var ans = 0;
        for(int i=1; i<n; i++)
        {
            var k = -1;
            while(stack.Count > 0 && heights[i] < stack.Peek().h)
            {
                var top = stack.Pop();
                ans = Math.Max(ans, top.h);
                var surface = top.h * (i - top.index);
                ans = Math.Max(ans, surface);
                k = top.index;
            }
            stack.Push((heights[i], k != -1 ? k : i ));
        }

        while (stack.Count > 0)
        {
            var top = stack.Pop();
            ans = Math.Max(ans, top.h);
            var surface = top.h * (n - top.index);
            ans = Math.Max(ans, surface);
        }
        return ans;

    }
}
