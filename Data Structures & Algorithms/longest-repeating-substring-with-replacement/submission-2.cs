public class Solution 
{
    public int CharacterReplacement(string s, int k) 
    {
        int res = 0;

        for(int i = 0; i < s.Length; i++)
        {
            Dictionary<char,int> freq = new();
            int maxf = 0;

            for(int j = i; j < s.Length; j++)
            {
                if(freq.ContainsKey(s[j]))
                    freq[s[j]]++;
                else
                    freq[s[j]] = 1;

                maxf = Math.Max(maxf, freq[s[j]]);

                if((j - i + 1) - maxf <= k)
                {
                    res = Math.Max(res, j - i + 1);
                }
            }
        }

        return res;
    }
}
