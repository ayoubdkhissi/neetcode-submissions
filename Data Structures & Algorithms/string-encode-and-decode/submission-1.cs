public class Solution {

    public string Encode(List<string> strs)
    {
        if (strs.Count == 0)
            return null;

        var sb = new StringBuilder();

        for(int i=0; i<strs.Count; i++)
        {
            sb.Append(Convert.ToBase64String(Encoding.UTF8.GetBytes(strs[i])));
            if(i != strs.Count - 1)
                sb.Append(";");
        }

        return sb.ToString();
    }

    public  List<string> Decode(string s)
    {
        if (s is null)
            return [];
        var ans = new List<string>();
        var encodedStrs = s.Split(";");

        foreach (var encodedStr in encodedStrs)
        {
            var str = Encoding.UTF8.GetString(Convert.FromBase64String(encodedStr));
            ans.Add(str);
        }

        return ans;
    }
}
