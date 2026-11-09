public class Solution
{
	public int NumRescueBoats(int[] people, int limit)
	{
		var result = 0;
		var sortedPeople = people.OrderByDescending(x => x).ToArray();

		var i = 0;
		var j = sortedPeople.Length - 1;
		while(i <= j)
		{
			var weight = 0;
			var peopleOnBoat = 0;
			while(i <= j && i < sortedPeople.Length 
				&& weight + sortedPeople[i] <= limit
				&& peopleOnBoat < 2)
			{
				weight += sortedPeople[i++];
				peopleOnBoat++;
			}
			while(i <= j
				&& weight + sortedPeople[j] <= limit
				&& peopleOnBoat < 2)
			{
				weight += sortedPeople[j--];
				peopleOnBoat++;
			}
			result++;
		}

		return result;
	}
}