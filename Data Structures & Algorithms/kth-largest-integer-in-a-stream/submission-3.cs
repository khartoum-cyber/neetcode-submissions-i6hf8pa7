public class KthLargest 
{
    private PriorityQueue<int, int> minHeap = new();
    private int k;

    public KthLargest(int k, int[] nums) 
    {
        minHeap = new PriorityQueue<int, int>();
        this.k = k;

        foreach(var num in nums)
        {
            minHeap.Enqueue(num, num);
            while(minHeap.Count > k)
                minHeap.Dequeue();
        }
    }
    
    public int Add(int val) 
    {
        minHeap.Enqueue(val, val);

        while(minHeap.Count > k)
            minHeap.Dequeue();

        return minHeap.Peek();
    }
}
