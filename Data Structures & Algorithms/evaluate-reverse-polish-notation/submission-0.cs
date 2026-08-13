public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

    
        int num;
        foreach(var x in tokens)
        {
            if(int.TryParse(x, out num))
            {
                stack.Push(num);
            }
            else
            {
                if (x == "-")
                {
                    var r = stack.Pop();
                    var l = stack.Pop();
                    stack.Push(l - r);
                }
                if (x == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                if(x == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                if(x == "/")
                {
                    var r = stack.Pop();
                    var l = stack.Pop();
                    if (r == 0)
                        stack.Push(0);
                    else
                        stack.Push(l/r);
                }
            }
        }

        return stack.Pop();
    }
}
