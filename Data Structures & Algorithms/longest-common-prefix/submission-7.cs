public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var first = strs[0];
        var prefixLength = first.Length;

        for(int i=0; i<strs.Length && prefixLength > 0; i++)
        {
            var s = strs[i];
            var j = 0;
            var min = Math.Min(s.Length, prefixLength);
            while(j < min && first[j] == s[j])
                j++;
            prefixLength = j;
        }


        return first[..prefixLength];
    }

}