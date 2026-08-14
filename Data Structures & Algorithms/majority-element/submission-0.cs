public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int,int> freq = new();
        int mElement = 0;
        int maxFreq = 0;

        foreach(var num in nums)
        {
            if(!freq.ContainsKey(num))
                freq[num] = 1;
            else
                freq[num]++;
            
            if(freq[num] > maxFreq)
            {
                maxFreq = freq[num];
                mElement = num;
            }
        }

        return mElement;
    }
}