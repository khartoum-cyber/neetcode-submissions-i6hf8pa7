public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        HashSet<int> set = new();

        foreach(var num in nums)
        {
            if(!set.Contains(num))
                set.Add(num);
            else
                return num;
        }

        return -1;
    }
}
