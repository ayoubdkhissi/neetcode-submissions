public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new int[tokens.Length];
        int top = 0;

        foreach (var token in tokens)
        {
            if (token.Length == 1 && token[0] is '+' or '-' or '*' or '/')
            {
                int b = stack[--top];
                int a = stack[top - 1];

                stack[top - 1] = token[0] switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    _ => throw new InvalidOperationException()
                };
            }
            else
            {
                stack[top++] = int.Parse(token);
            }
        }

        return stack[0];
    }
}