public class Solution
{
	public int ScoreOfString(string s)
	{
		var score = 0;
		for(int i=0; i<s.Length-1; i++)
		{
			var x = (int)s[i];
			var y = (int)s[i + 1];
			score += Math.Abs(y-x);
		}
		return score;
	}
}