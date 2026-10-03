public class Solution {
    public int MajorityElement(int[] nums)
    {
        var count = new Dictionary<int, int>();
        foreach(var x in nums)
        {
            if (count.ContainsKey(x))
                count[x]++;
            else
                count.Add(x, 1);

            if (count[x] > nums.Length / 2)
                return x;
        }

        return 0;

    }
}