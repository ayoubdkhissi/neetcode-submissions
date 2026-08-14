public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var n = temperatures.Length;
        var ans = new int[n];
        var stack = new Stack<(int p1, int p2)>();

        for(int i=0; i<n; i++)
        {
            if(stack.Count == 0)
            {
                stack.Push((temperatures[i], i));
                continue;
            }

            while(stack.Count > 0 && stack.Peek().p1 < temperatures[i])
            {
                var pair = stack.Pop();
                ans[pair.p2] = i-pair.p2;
            }
            stack.Push((temperatures[i], i));
        }

        return ans;
    }
}

