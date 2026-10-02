public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var first = strs[0];
        var prefixLength = first.Length;

        for(int i=0; i<strs.Length && prefixLength > 0; i++)
        {
            var s = strs[i];
            prefixLength = Math.Min(s.Length, prefixLength);

            while (prefixLength > 0 &&
            !first.AsSpan(0, prefixLength)
            .SequenceEqual(s.AsSpan(0, prefixLength)))
            {
                prefixLength--;
            }
        }
        return first[..prefixLength];
    }
}