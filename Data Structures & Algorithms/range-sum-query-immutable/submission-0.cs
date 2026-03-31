public class NumArray 
{
    private int[] _prefix;

    public NumArray(int[] nums) 
    {
        _prefix = new int[nums.Length];
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            _prefix[i] = sum;
        }
    }
    
    public int SumRange(int left, int right) 
    {
        int preRight = _prefix[right];
        int preLeft = left > 0 ? _prefix[left - 1] : 0;

        return preRight - preLeft;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */