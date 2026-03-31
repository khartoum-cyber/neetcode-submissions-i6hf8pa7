public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char,int> freq1 = new();
        Dictionary<char,int> freq2 = new();

        foreach(var ch in s)
        {
            if(freq1.ContainsKey(ch))
                freq1[ch]++;
            else
                freq1[ch] = 1;
        }

        foreach(var ch in t)
        {
            if(freq2.ContainsKey(ch))
                freq2[ch]++;
            else
                freq2[ch] = 1;
        }

        foreach(var kvp in freq1)
        {
            if(!freq2.ContainsKey(kvp.Key) || freq2[kvp.Key] != kvp.Value)
                return false;
        }

        return true;
    }
}
