public class Solution {
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        foreach (var op in operations)
        {
            if (int.TryParse(op, out int num))
            {
                stack.Push(num);
            }
            else if(op == "+")
            {
                var top = stack.Pop();
                var secondTop = stack.Peek();
                stack.Push(top);
                stack.Push(top + secondTop);
            }
            else if(op == "D")
            {
                stack.Push(stack.Peek() * 2);
            }
            else if(op == "C")
            {
                stack.Pop();
            }

        }

        return stack.Sum();
    }
}