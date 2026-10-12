public class Solution
{
	public string MergeAlternately(string word1, string word2)
	{
		var sb = new StringBuilder();
		var n = Math.Min(word1.Length, word2.Length);
		for (int i = 0; i < n; i++)
		{
			sb.Append(word1[i]);
			sb.Append(word2[i]);
		}
		sb.Append(word1.Substring(n, word1.Length - n));
		sb.Append(word2.Substring(n, word2.Length - n));
		return sb.ToString();
	}
}