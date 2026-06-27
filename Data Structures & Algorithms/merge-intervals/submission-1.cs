public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        List<int[]> res = new();

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        res.Add(intervals[0]);

        foreach(var interval in intervals)
        {
            int start = interval[0];
            int end = interval[1];
            int lastEnd = res[res.Count - 1][1];

            if(start <= lastEnd)
            {
                res[res.Count - 1][1] = Math.Max(end, lastEnd);
            }
            else
            {
                res.Add(new int[] {start, end});
            }
        }

        return res.ToArray();
    }
}
