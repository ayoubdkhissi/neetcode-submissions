public class MyQueue
{
    private readonly Stack<int> Stack;
    private readonly Stack<int> Stack2;

    public MyQueue()
    {
        Stack = new Stack<int>();
        Stack2 = new Stack<int>();
    }

    public void Push(int x)
    {
        while(Stack.Count > 0)
            Stack2.Push(Stack.Pop());
        Stack.Push(x);
        while (Stack2.Count > 0)
            Stack.Push(Stack2.Pop());
    }

    public int Pop()
    {
        return Stack.Pop();
    }

    public int Peek()
    {
        return Stack.Peek();
    }

    public bool Empty()
    {
        return Stack.Count == 0;
    }
}