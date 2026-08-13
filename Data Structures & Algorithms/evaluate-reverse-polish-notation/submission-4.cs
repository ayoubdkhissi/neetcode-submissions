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
                var b = stack.Pop();
                var a = stack.Pop();
                switch (x)
                {
                    case  "-":
                        stack.Push(a - b);
                        break;
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    case "/":
                        stack.Push(a / b);
                        break;
                    default: continue;
                }
            }
        }

        return stack.Pop();
    }
}