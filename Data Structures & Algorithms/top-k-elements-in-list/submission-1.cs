public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        var queue = new PriorityQueue<int, int>();

        foreach(var x in nums)
        {
            if (count.ContainsKey(x))
                count[x]++;
            else
                count.Add(x, 1);
        }

        foreach(var kvp in count)
        {
            queue.Enqueue(kvp.Key, -kvp.Value);
        }

        var ans = new int[k];

        for(int i=0; i<k; i++)
        {
            ans[i] = queue.Dequeue();
        }

        return ans;
    }
}
