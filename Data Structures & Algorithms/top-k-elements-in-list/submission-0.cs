public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> map = new();

        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
                map[num] = 0;

            map[num]++;
        }

        PriorityQueue<int, int> pq = new(); // min-heap keyed by frequency

        foreach(var pair in map)
        {
            pq.Enqueue(pair.Key, pair.Value);

            if(pq.Count > k)
                pq.Dequeue();
        }

        return pq.UnorderedItems.Select(x => x.Element).ToArray();
    }
}
