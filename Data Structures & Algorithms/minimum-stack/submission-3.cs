public class MinStack
{
    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;
    public MinStack()
    {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (_stack.Count == 0)
            _minStack.Push(val);

        _stack.Push(val);

        if (_minStack.Peek() < val)
        {
            _minStack.Push(_minStack.Peek());
        }
        else
            _minStack.Push(val);
    }

    public void Pop()
    {
        _stack.Pop();
        _minStack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}