public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var n = position.Length;
        var arr = new (int p, int s, double arrive)[n];
        var stack = new Stack<double>();
        for (int i = 0; i < n; i++)
            arr[i] = (position[i], speed[i], (target - position[i]) / (double)speed[i]);

        arr = [.. arr.OrderBy(pair => pair.p)];

        for (int i = n - 1; i >= 0; i--)
        {
            if (stack.Count == 0)
            {
                stack.Push(arr[i].arrive);
                continue;
            }

            if (stack.Peek() < arr[i].arrive)
            {
                stack.Push(arr[i].arrive);
            }
        }

        return stack.Count;
    }
}

