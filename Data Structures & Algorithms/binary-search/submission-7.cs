public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        return RecSearch(nums, target, 0, nums.Length - 1);
    }

    private int RecSearch(int[] nums, int target, int l, int r)
    {
        if(l > r)
            return -1;

        int mid = l + (r - l) / 2;

        if(nums[mid] == target)
            return mid;
        else if(nums[mid] > target)
            return RecSearch(nums, target, l, mid - 1);
        else
            return RecSearch(nums, target, mid + 1, r);
    }
}
