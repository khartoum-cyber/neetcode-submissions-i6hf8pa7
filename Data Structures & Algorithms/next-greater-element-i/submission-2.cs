public class Solution 
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        Stack<int> st = new();
        Dictionary<int,int> map = new();

        for(int i = 0; i < nums1.Length; i++)
        {
            map[nums1[i]] = i;
        }

        int[] res = new int[nums1.Length];
        Array.Fill(res, -1);

        foreach(var num in nums2)
        {
            while(st.Count > 0 && num > st.Peek())
            {
                int val = st.Pop();
                if(map.ContainsKey(val))
                {
                    int idx = map[val];
                    res[idx] = num;
                }
            }

            if(map.ContainsKey(num))
            {
                st.Push(num);
            }
        }

        return res;
    }
}