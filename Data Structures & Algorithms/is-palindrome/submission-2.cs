public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        var sb = new StringBuilder(s.Length);

        foreach(char ch in s)
        {
            if(char.IsLetterOrDigit(ch))
                sb.Append(char.ToLowerInvariant(ch));
        }

        string trimmed = sb.ToString();

        return Rec(trimmed, 0, trimmed.Length - 1);
    }

    private bool Rec(string trimmed, int left, int right)
    {
        if(left >= right)
            return true;
        
        if(trimmed[left] != trimmed[right])
            return false;

        return Rec(trimmed, left + 1, right - 1);
    }
}
