public class Solution {
    public int Trap(int[] height)
    {
        var n = height.Length;
        var sum = 0;
        var min_max_left_right = new int[n];

        // for each element, calculate the Max on the left of it.
        var tmp_max = 0;
        for (int i = 0; i < n; i++)
        {
            if (height[i] > tmp_max)
                tmp_max = height[i];

            min_max_left_right[i] = tmp_max;
        }

        // for each element, calculate the Max on the right of it.
        tmp_max = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            if (height[i] > tmp_max)
                tmp_max = height[i];

            min_max_left_right[i] = Math.Min(min_max_left_right[i], tmp_max);
        }

        // to know the amount of water a cell will hold, we just need the minimun of the max on left and right minus its height.
        for(int i=0; i<n; i++)
        {
            sum += Math.Max(min_max_left_right[i] - height[i], 0);
        }


        return sum;
    }
}
