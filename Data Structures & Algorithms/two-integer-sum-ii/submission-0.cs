public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var n = numbers.Length;
        var i = 0;
        var j = n - 1;

        while (i < j)
        {
            if (numbers[i] + numbers[j] == target)
                return [i + 1, j + 1];

            if (numbers[i] + numbers[j] < target)
                i++;

            else
                j--;
        }

        return [0, 0];
    }
}
