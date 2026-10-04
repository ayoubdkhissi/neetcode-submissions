public class MyHashSet
{
    const int MOD = 15247;
    private LinkedList<int>[] Buckets = new LinkedList<int>[MOD];
    public MyHashSet()
    {

    }

    public void Add(int key)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is null)
        {
            Buckets[hashed] = new([key]);
        }
        else if (!Buckets[hashed].Contains(key))
        {
            Buckets[hashed].AddLast(key);
        }
    }

    public void Remove(int key)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is not null)
        {
            Buckets[hashed].Remove(key);
        }
    }

    public bool Contains(int key)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is not null && Buckets[hashed].Contains(key))
            return true;
        return false;
    }
}