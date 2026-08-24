public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        if(s1.Length > s2.Length)
            return false;
        
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];

        for(int i = 0; i < s1.Length; i++)
        {
            freq1[s1[i] - 'a']++;
            freq2[s2[i] - 'a']++;
        }

        if(Enumerable.SequenceEqual(freq1, freq2))
            return true;
        
        int start = 0;
        int end = s1.Length;

        while(end < s2.Length)
        {
            freq2[s2[start] - 'a']--;
            freq2[s2[end] - 'a']++;

            if(Enumerable.SequenceEqual(freq1, freq2))
                return true;

            start++;
            end++;
        }

        return false;
    }
}
