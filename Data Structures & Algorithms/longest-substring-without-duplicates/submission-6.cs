public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{

		if(s.Length ==  0) return 0;

		var max = 1;
		var set = new HashSet<char>{ s[0] };

		var l = 0;
		var r = 1;

		while(r < s.Length)
		{
			max = Math.Max(set.Count, max);

			var currentCount = set.Count;
			set.Add(s[r]);

			if(currentCount == set.Count)
			{
				while (s[l] != s[r])
				{
					set.Remove(s[l]);
					l++;
				}
				l++;
			}

			r++;
		}

		return Math.Max(set.Count, max); 

	}
}