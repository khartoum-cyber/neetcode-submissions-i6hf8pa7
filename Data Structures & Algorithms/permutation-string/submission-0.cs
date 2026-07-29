public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        if(s1.Length > s2.Length)
            return false;

        int[] freqS1 = new int[26];
        int[] freqS2 = new int[26];

        for(int i = 0; i < s1.Length; i++)
        {
            freqS1[s1[i] - 'a']++;
            freqS2[s2[i] - 'a']++;
        }

        int start = 0;
        int end = s1.Length;

        if(Enumerable.SequenceEqual(freqS1, freqS2))
            return true;
        
        while(end < s2.Length)
        {
            freqS2[s2[start] - 'a']--;
            freqS2[s2[end] - 'a']++;

            if(Enumerable.SequenceEqual(freqS1, freqS2))
                return true;

            start++;
            end++;
        }

        return false;
    }
}
