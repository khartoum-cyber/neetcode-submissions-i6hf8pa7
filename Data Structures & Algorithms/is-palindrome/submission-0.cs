public class Solution {
    public bool IsPalindrome(string s) 
    {
        var sb = new StringBuilder();

        foreach(char ch in s.ToLower())
        {
            if(char.IsLetterOrDigit(ch))
                sb.Append(ch);
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
