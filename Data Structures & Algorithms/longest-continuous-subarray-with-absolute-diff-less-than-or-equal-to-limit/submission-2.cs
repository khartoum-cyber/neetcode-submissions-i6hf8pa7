public class Solution 
{
    public int LongestSubarray(int[] nums, int limit) 
    {
        var minQ = new LinkedList<int>();
        var maxQ = new LinkedList<int>();

        int l = 0;
        int res = 0;

        for(int r = 0; r < nums.Length; r++)
        {
            while(minQ.Count > 0 && nums[r] < minQ.Last.Value)
            {
                minQ.RemoveLast();
            }

            while(maxQ.Count > 0 && nums[r] > maxQ.Last.Value)
            {
                maxQ.RemoveLast();
            }

            minQ.AddLast(nums[r]);
            maxQ.AddLast(nums[r]);

            while(maxQ.First.Value - minQ.First.Value > limit)
            {
                if(nums[l] == maxQ.First.Value)
                {
                    maxQ.RemoveFirst();
                }
                if(nums[l] == minQ.First.Value)
                {
                    minQ.RemoveFirst();
                }
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}