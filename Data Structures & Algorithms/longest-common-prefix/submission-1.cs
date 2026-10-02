public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var result = strs[0];
        foreach(var s in strs)
        {
            var i = 0;
            while (i < result.Length && i < s.Length)
            {
                if (result[i] == s[i])
                    i++;
                else
                    break;
            }
            result = result.Substring(0, i);
        }

        return result;
    }

}