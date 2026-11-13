public class Solution
{
	public int CharacterReplacement(string s, int k)
	{
		var result = 1;

		var i = 0;
		var j = 1;
		var map = new Dictionary<char, int>() { { s[0], 1 } };
		var mostCommon = map.MaxBy(x => x.Value);
		var replacements = 0;
		while(j < s.Length)
		{
			replacements = map.Where(x => x.Key != mostCommon.Key).Sum(x => x.Value);

			if (replacements > k)
			{
				if (map.ContainsKey(s[i]) && map[s[i]] <= 1)
					map.Remove(s[i]);
				else if (map.ContainsKey(s[i]) && map[s[i]] > 1)
					map[s[i]]--;
				i++;
				if (map.Count > 0)
					mostCommon = map.MaxBy(x => x.Value);
				continue;

			}

			if (s[j] == mostCommon.Key || (replacements <= k && k>0) || map.Count == 0)
			{
				if (map.ContainsKey(s[j]))
					map[s[j]]++;
				else
					map.Add(s[j], 1);
				j++;
			}
			else
			{
				result = Math.Max(result, mostCommon.Value + (k<replacements? k:replacements));
				if (map.ContainsKey(s[i]) && map[s[i]] <= 1)
					map.Remove(s[i]);
				else if(map.ContainsKey(s[i]) && map[s[i]] > 1)
					map[s[i]]--;
				i++;
			}

			if(map.Count > 0)
				mostCommon = map.MaxBy(x => x.Value);
			result = Math.Max(result, mostCommon.Value + (k < replacements ? k : replacements));
		}
		replacements = map.Where(x => x.Key != mostCommon.Key).Sum(x => x.Value);
		result = Math.Max(result, mostCommon.Value + (k < replacements ? k : replacements));

		return result;
	}
}