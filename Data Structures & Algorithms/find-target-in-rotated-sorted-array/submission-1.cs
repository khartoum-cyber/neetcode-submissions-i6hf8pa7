public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;

        while(l < r)
        {
            int mid = l + (r - l) / 2;

            if(nums[mid] > nums[r])
                l = mid + 1;
            else
                r = mid;
        }

        int minIndex = l;
        
        if(minIndex == 0)
            (l, r) = (0, n - 1);
        else if(target >= nums[0] && target <= nums[minIndex - 1])
            (l, r) = (0, minIndex - 1);
        else
            (l, r) = (minIndex, n - 1);

        while(l <= r)
        {
            int mid = l + (r - l) / 2;

            if(nums[mid] < target)
                l = mid + 1;
            else if(nums[mid] > target)
                r = mid - 1;
            else
                return mid;
        }

        return -1;
    }
}
