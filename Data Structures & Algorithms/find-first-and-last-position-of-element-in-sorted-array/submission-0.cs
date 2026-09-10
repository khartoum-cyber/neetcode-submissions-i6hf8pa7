public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        int first = FindFirst(0, nums.Length - 1, nums, target);
        int last = FindLast(0, nums.Length - 1, nums, target);

        return new int[] { first, last };
    }

    private int FindFirst(int l, int r, int[] nums, int target)
    {
        int result = -1;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;

            if(nums[mid] > target)
                r = mid - 1;
            else if(nums[mid] < target)
                l = mid + 1;
            else
            {
                result = mid;
                r = mid - 1;
            }
        }

        return result;
    }

    private int FindLast(int l, int r, int[] nums, int target)
    {
        int result = -1;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;

            if(nums[mid] > target)
                r = mid - 1;
            else if(nums[mid] < target)
                l = mid + 1;
            else
            {
                result = mid;
                l = mid + 1;
            }
        }

        return result;
    }
}