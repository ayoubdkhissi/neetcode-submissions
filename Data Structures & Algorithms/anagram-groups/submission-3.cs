public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var count = new int[26];

            foreach (char c in s)
                count[c - 'a']++;

            var sb = new System.Text.StringBuilder();

            foreach (int n in count)
            {
                sb.Append(n);
                sb.Append('#');
            }

            string key = sb.ToString();

            if (!map.TryGetValue(key, out var list))
            {
                list = new List<string>();
                map[key] = list;
            }

            list.Add(s);
        }

        return map.Values.ToList();
    }
}
