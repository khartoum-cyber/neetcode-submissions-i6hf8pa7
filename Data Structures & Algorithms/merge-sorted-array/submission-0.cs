public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int[] nums1Copy = new int[m];

        Array.Copy(nums1, nums1Copy, m);

        int idx = 0;
        int i = 0;
        int j = 0;

        while(idx < m + n)
        {
            if(j >= n || (i < m && nums1Copy[i] <= nums2[j]))
            {
                nums1[idx++] = nums1Copy[i++];
            }
            else
            {
                nums1[idx++] = nums2[j++];
            }
        }
    }
}