public class MinStack
{
    private readonly Stack<int> _stack;
    private readonly SortedDictionary<int, int> _prioQueue;
    public MinStack()
    {
        _stack = new Stack<int>();
        _prioQueue = new SortedDictionary<int, int>();
    }

    public void Push(int val)
    {
        _stack.Push(val);
        if (_prioQueue.ContainsKey(val))
            _prioQueue[val]++;
        else
            _prioQueue.Add(val, 1);
    }

    public void Pop()
    {
        var popped = _stack.Pop();
        if (_prioQueue[popped] == 1)
        {
            _prioQueue.Remove(popped);
        }
        else
            _prioQueue[popped]--;
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _prioQueue.FirstOrDefault().Key;
    }
}
