public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int res = 0;

        for(int i = 0; i < s.Length; i++)
        {
            HashSet<char> charSet = new();

            for(int j = i; j < s.Length; j++)
            {
                if(charSet.Contains(s[j]))
                    break;
                else
                    charSet.Add(s[j]);
            }

            res = Math.Max(res, charSet.Count);
        }

        return res;
    }
}
