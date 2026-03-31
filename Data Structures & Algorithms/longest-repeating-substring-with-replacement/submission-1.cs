public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> count = new();

        int l = 0;
        int maxF = 0;
        int res = 0;

        for(int r = 0; r < s.Length; r++)
        {
            char c = s[r];
            if(!count.ContainsKey(c))
                count[c] = 1;
            else
                count[c]++;

            if(count[c] > maxF)
                maxF = count[c];
            
            while((r - l + 1) - maxF > k)
            {
                char leftChar = s[l];
                count[leftChar]--;
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
