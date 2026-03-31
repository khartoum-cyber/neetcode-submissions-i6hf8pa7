public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
        PriorityQueue<int, int> minHeap = new();

        foreach(var stone in stones)
        {
            minHeap.Enqueue(stone, -stone);
        }

        while(minHeap.Count > 1)
        {
            var first = minHeap.Dequeue();
            var second = minHeap.Dequeue();
            var cur = first - second;

            if(cur != 0)
            {
                minHeap.Enqueue(cur, -cur);

            }
        }

        return minHeap.Count == 0 ? 0 : minHeap.Dequeue();
    }
}
