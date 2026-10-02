public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var first = strs[0];
        var prefixLength = first.Length;

        for(int i=0; i<strs.Length && prefixLength > 0; i++)
        {
            var s = strs[i];
            var newPrefixLength = 0;
            for(int j=0; j<prefixLength && j<s.Length; j++)
            {
                if (first[j] == s[j])
                    newPrefixLength++;
                else
                    break;
            }
            prefixLength = newPrefixLength;
        }


        return first[..prefixLength];
    }


}