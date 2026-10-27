public class Solution
{
	public bool ValidWordAbbreviation(string word, string abbr)
	{
		var sb = new StringBuilder();
		var i = 0;
		while(i <abbr.Length)
		{
			if (char.IsAsciiLetterLower(abbr[i]))
			{
				sb.Append(abbr[i]);
				i++;
			}
			else
			{
				if (abbr[i] == '0')
					return false;
				var numString = new StringBuilder();
				while (i < abbr.Length && !char.IsAsciiLetterLower(abbr[i]))
				{
					numString.Append(abbr[i]);
					i++;
				}
				var repeats = string.Join("", Enumerable.Repeat('#', int.Parse(numString.ToString())));
				sb.Append(repeats).ToString();
			}
			
		}
			
		abbr = sb.ToString();

		if (abbr.Length != word.Length)
			return false;

		for(i= 0; i<abbr.Length; i++)
		{
			if (abbr[i] != '#' && abbr[i] != word[i])
				return false;
		}

		return true;
	}
}