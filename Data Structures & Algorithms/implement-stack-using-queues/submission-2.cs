public class MyStack
{
    private readonly Queue<int> Queue1;
    public MyStack()
    {
        Queue1 = new Queue<int>();
    }

    public void Push(int x)
    {
        // Dequeue everything from Queue1 into Queue2
        Queue1.Enqueue(10);
        Queue1.Enqueue(x);
        while(Queue1.Peek() != 10)
            Queue1.Enqueue(Queue1.Dequeue());
        Queue1.Dequeue();

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
