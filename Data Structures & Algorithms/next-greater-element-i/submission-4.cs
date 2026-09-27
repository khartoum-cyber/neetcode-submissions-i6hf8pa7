public class Solution 
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        Dictionary<int,int> map = new();

        for(int i = 0; i < nums1.Length; i++)
        {
            map[nums1[i]] = i;
        }

        int[] res = new int[nums1.Length];
        Array.Fill(res, -1);

        for(int i = 0; i < nums2.Length; i++)
        {
            if(!map.ContainsKey(nums2[i]))
                continue;
            
            for(int j = i + 1; j < nums2.Length; j++)
            {
                if(nums2[j] > nums2[i])
                {
                    int idx = map[nums2[i]];
                    res[idx] = nums2[j];
                    break;
                }
            }
        }

        return res;
    }
}