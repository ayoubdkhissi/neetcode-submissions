public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {

        var map = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var ordered_s = new string(s.Order().ToArray());

            if(map.ContainsKey(ordered_s))
            {
                map[ordered_s].Add(s);
            }
            else
            {
                map.Add(ordered_s, [s]);
            }
        }

        return map.Select(x => x.Value).ToList();
    }
}
