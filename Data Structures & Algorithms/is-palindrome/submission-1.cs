public class Solution {
    public bool IsPalindrome(string s) 
    {
        var sb = new StringBuilder(s.Length);

        foreach(char ch in s)
        {
            if(char.IsLetterOrDigit(ch))
                sb.Append(char.ToLowerInvariant(ch));
        }

        string trimmed = sb.ToString();
        int r = trimmed.Length - 1;

        for(int l = 0; l < r; l++)
        {
            if(trimmed[l] != trimmed[r])
                return false;
            
            r--;
        }

        return true;
    }
}
