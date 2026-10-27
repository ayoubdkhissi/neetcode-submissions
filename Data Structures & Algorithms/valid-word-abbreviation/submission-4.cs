public class Solution
{
	public bool ValidWordAbbreviation(string word, string abbr)
	{
		var i = 0;
		var j = 0;
		while (i < word.Length && j < abbr.Length)
		{
			if (char.IsAsciiLetterLower(abbr[j]) && abbr[j] == word[i])
			{
				i++;
				j++;
			}
			else if (char.IsAsciiLetterLower(abbr[j]) && abbr[j] != word[i])
			{
				return false;
			}
			else
			{
				if (abbr[j] == '0')
					return false;
				var sb = new StringBuilder();
				while(j < abbr.Length && !char.IsAsciiLetterLower(abbr[j]))
				{
					sb.Append(abbr[j]);
					j++;
				}
				i += int.Parse(sb.ToString());
			}

		}
		return i == word.Length && j == abbr.Length;
	}
}