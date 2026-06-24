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
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        for(int i = 0; i < intervals.Count - 1; i++)
        {
            Interval curr = intervals[i];
            Interval next = intervals[i + 1];

            if(curr.end > next.start)
                return false;
        }

        return true;
    }
}