public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var n = position.Length;
        var arr = new (int p, int s, double arrive)[n];
        for (int i = 0; i < n; i++)
            arr[i] = (position[i], speed[i], (target - position[i]) / (double)speed[i]);

        arr = arr.OrderBy(pair => pair.p).ToArray();

        for (int i = n-1; i > 0; i--)
        {
            if (arr[i-1].arrive < arr[i].arrive)
            {
                arr[i-1].arrive = arr[i].arrive;
            }
        }

        return arr.GroupBy(x => x.arrive).Count();
    }
}

