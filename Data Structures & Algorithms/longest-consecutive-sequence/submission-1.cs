public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> set = new(nums);
        int res = 0;

        foreach(var num in nums)
        {

            if (!set.Contains(num - 1))
            {
                int count = 1;
                int curr = num + 1;

                while (set.Contains(curr))
                {
                    count++;
                    curr++;
                }

                res = Math.Max(res, count);
            }
        }

        return res;
    }
}
