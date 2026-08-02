public class Solution {
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach(var c in s)
        {
            if("({[".Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                stack.TryPop(out char last);
                if (c == ')' && last != '(')
                    return false;
                if (c == ']' && last != '[')
                    return false;
                if (c == '}' && last != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
