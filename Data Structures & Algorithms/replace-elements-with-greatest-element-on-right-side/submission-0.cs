public class Solution
{
	public int[] ReplaceElements(int[] arr)
	{
		var n = arr.Length;
		var lastBiggest = arr[n - 1];
		arr[n - 1] = -1;
		for(int i=n - 2; i >= 0; i--)
		{
			if(arr[i] < lastBiggest)
			{
				arr[i] = lastBiggest;
			}
			else
			{
				var tmp = lastBiggest;
				lastBiggest = arr[i];
				arr[i] = tmp;
			}
		}
		return arr;
	}
}