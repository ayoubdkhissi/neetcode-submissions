public class Solution
{
	public string SimplifyPath(string path)
	{
		var result = new StringBuilder("/");

		var elements = path.Split("/");
		var stack = new Stack<string>();

		foreach(var s in elements)
		{
			if (s == ".." && stack.Count > 0)
			{
				stack.Pop();
			}
			else if(!string.IsNullOrEmpty(s) && s != ".." && s != ".")
			{
				stack.Push(s);
			}
		}

		return $"/{string.Join("/", stack.Reverse())}";
	}
}