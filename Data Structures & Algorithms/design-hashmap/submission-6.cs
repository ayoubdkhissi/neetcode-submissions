public class MyHashMap
{
    const int MOD = 500;
    private readonly LinkedList<(int key, int value)>[] Buckets;

    public MyHashMap()
    {
        Buckets = new LinkedList<(int key, int value)>[MOD];
    }

    public void Put(int key, int value)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is null)
        {
            Buckets[hashed] = new LinkedList<(int key, int value)>([(key, value)]);
        }
        else
        {
            var node = Buckets[hashed].First;
            var modified = false;
            while(node is not null)
            {
                if(node.Value.key == key)
                {
                    node.Value = (key, value);
                    modified = true;
                    break;
                }
                node = node.Next;
            }
            if(!modified)
            {
                Buckets[hashed].AddLast((key, value));
            }
        }
    }

    public int Get(int key)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is not null)
        {
            foreach(var x in Buckets[hashed])
            {
                if (x.key == key)
                    return x.value;
            }
        }
        return -1;
    }

    public void Remove(int key)
    {
        var hashed = key % MOD;
        if (Buckets[hashed] is not null && Buckets[hashed].Count > 0)
        {
            var prev = Buckets[hashed].First;
            var next = prev.Next;

            if(prev.Value.key == key)
            {
                Buckets[hashed].RemoveFirst();
                return;
            }

            while(next is not null)
            {
                if(next.Value.key == key)
                {
                    Buckets[hashed].Remove(next);
                    break;
                }
                prev = next;
                next = next.Next;
            }
        }
    }
}