public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var count = new int[26];

            foreach (var c in s)
            {
                count[c - 'a'] += 1;
            }
            var key = string.Join(",", count);
            if (map.ContainsKey(key))
            {
                map[key].Add(s);
            }
            else
            {
                map.Add(key, [s]);
            }
        }

        return map.Select(x => x.Value).ToList();
    }
}
