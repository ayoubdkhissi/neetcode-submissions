public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var result = strs.MinBy(x => x.Length) ?? string.Empty;
        foreach(var s in strs)
        {
            var i = 0;
            while (i < result.Length)
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