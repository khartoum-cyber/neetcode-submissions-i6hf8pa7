public class Solution 
{
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> freq = new();

        int res = 0;
        int left = 0;
        int maxf = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(freq.ContainsKey(s[right]))
                freq[s[right]]++;
            else
                freq[s[right]] = 1;

            maxf = Math.Max(maxf, freq[s[right]]);
            
            while((right - left + 1) - maxf > k)
            {
                freq[s[left]]--;
                left++;
            }

            res = Math.Max(res, right - left + 1);
        }

        return res;
    }
}
