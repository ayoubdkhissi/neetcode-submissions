public class Solution {

    public string Encode(List<string> strs)
    {
        if (strs.Count == 0)
            return null;

        var sb = new StringBuilder();

        for(int i=0; i<strs.Count; i++)
        {
            var s = strs[i];
            sb.Append($"{s.Length}#{s}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        if (s is null)
            return [];

        var ans = new List<string>();

        for(int i=0; i<s.Length; i++)
        {
            var j = i;
            while (s[j] != '#')
            {
                j++;
            }
            var count = int.Parse(s.Substring(i, j - i));
            var str = s.Substring(j + 1, count);
            ans.Add(str);
            i = j + count;
        }

        return ans;
    }
}