/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution 
{
    public int MinMeetingRooms(List<Interval> intervals) 
    {
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        PriorityQueue<int,int> min_heap = new();

        foreach(var interval in intervals)
        {
            if(min_heap.Count > 0 && min_heap.Peek() <= interval.start)
                min_heap.Dequeue();
            
            min_heap.Enqueue(interval.end, interval.end);
        }

        return min_heap.Count;
    }
}
