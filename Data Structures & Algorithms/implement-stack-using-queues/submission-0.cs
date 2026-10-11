public class MyStack
{
    private readonly Queue<int> Queue1;
    private readonly Queue<int> Queue2;

    public MyStack()
    {
        Queue1 = new Queue<int>();
        Queue2 = new Queue<int>();
    }

    public void Push(int x)
    {
        // Dequeue everything from Queue1 into Queue2
        while(Queue1.Count > 0)
            Queue2.Enqueue(Queue1.Dequeue());
        Queue1.Enqueue(x);
        while (Queue2.Count > 0)
            Queue1.Enqueue(Queue2.Dequeue());
    }

    public int Pop()
    {
        return Queue1.Dequeue();
    }

    public int Top()
    {
        return Queue1.Peek();
    }

    public bool Empty()
    {
        return Queue1.Count == 0;
    }
}
