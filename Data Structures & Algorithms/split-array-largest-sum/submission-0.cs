public class Solution 
{
    public int SplitArray(int[] nums, int k) 
    {
        int l = nums.Max();
        int r = nums.Sum();

        while(l < r)
        {
            int mid = l + (r - l) / 2;

            if(CanSplit(nums, mid, k))
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }

        return l;
    }

    private bool CanSplit(int[] nums, int mid, int m)
    {
        int partitions = 1;
        int currentSum = 0;

        foreach(var num in nums)
        {
            if(currentSum + num > mid)
            {
                partitions++;
                currentSum = num;
            }
            else
            {
                currentSum += num;
            }
        }

        return partitions <= m;
    }
}