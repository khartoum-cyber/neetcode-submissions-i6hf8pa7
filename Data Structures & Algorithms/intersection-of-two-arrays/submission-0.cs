public class Solution 
{
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        var set = new HashSet<int>(nums1);
        set.IntersectWith(nums2);
        return set.ToArray();
    }
}