public class Solution {
    public int Search(int[] nums, int target) 
    {
        int l = 0;
        int r = nums.Length - 1;

        while(l <= r)
        {
            int mid = (r + l) / 2;

            if(nums[mid] == target)
                return mid;

            if(nums[l] <= nums[mid])
            {
                if (nums[l] <= target && target < nums[mid])
                    r = mid - 1;        // target in left half
                else
                    l = mid + 1;        // otherwise go right
            }
            else
            {
                if (nums[mid] < target && target <= nums[r])
                    l = mid + 1;        // target in right half
                else
                    r = mid - 1;
            }
        }
        return -1;
    }
}
