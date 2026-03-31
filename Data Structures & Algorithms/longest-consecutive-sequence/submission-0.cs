public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> set = new(nums);
        int res = 0;

        foreach(var num in nums)
        {
            int count = 0;
            int curr = num;
            while(set.Contains(curr))
            {
                count++;
                curr += 1;
            }

            res = Math.Max(res, count);
        }

        return res;
    }
}
