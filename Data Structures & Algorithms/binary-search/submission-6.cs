public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        return Rec(0, nums.Length - 1, nums, target);
    }

    private int Rec(int l, int r, int[] nums, int target)
    {
        if(l > r)
            return -1;
        
        int mid = l + (r - l) / 2;

        if(nums[mid] == target)
            return mid;
        
        return nums[mid] > target ? Rec(l, mid - 1, nums, target) : Rec(mid + 1, r, nums, target);
    }
}
