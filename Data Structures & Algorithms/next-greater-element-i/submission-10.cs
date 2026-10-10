public class Solution 
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        Dictionary<int,int> map = new();
        int n = nums1.Length;
        
        for(int i = 0; i < n; i++)
        {
            map[nums1[i]] = i;
        }

        Stack<int> stack = new();
        int[] res = new int[n];
        Array.Fill(res, -1);

        foreach(var num in nums2)
        {
            while(stack.Count > 0 && num > stack.Peek())
            {
                int val = stack.Pop();
                int idx = map[val];
                res[idx] = num;
            }

            if(map.ContainsKey(num))
                stack.Push(num);
        }

        return res;
    }
}