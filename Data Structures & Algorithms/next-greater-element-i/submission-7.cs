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

        Stack<int> stack = new();

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