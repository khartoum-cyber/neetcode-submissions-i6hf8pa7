public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) return false;

        Dictionary<char,int> map = new();

        foreach(char ch in s)
        {
            if(!map.ContainsKey(ch))
                map[ch] = 1;
            else
                map[ch]++;
        }

        foreach(char ch in t)
        {
            if(!map.ContainsKey(ch) || map[ch] == 0)
                return false;
            else
                map[ch]--;
        }

        return true;
    }
}