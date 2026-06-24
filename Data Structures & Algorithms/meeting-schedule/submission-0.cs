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
    public bool CanAttendMeetings(List<Interval> intervals) 
    {
        var sorted = intervals.OrderBy(i => i.start).ToList();

        for(int i = 0; i < sorted.Count - 1; i++)
        {
            Interval curr = sorted[i];
            Interval next = sorted[i + 1];

            if(curr.end > next.start)
                return false;
        }

        return true;
    }
}