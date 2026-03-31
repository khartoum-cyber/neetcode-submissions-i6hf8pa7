public class Solution {
    public string MinWindow(string s, string t) 
    {
        
if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        return "";

    // Frequency map for characters required from t
    var need = new Dictionary<char, int>();
    foreach (char c in t)
    {
        if (!need.ContainsKey(c))
            need[c] = 0;
        need[c]++;
    }

    int required = need.Count; // how many unique chars must be satisfied
    int formed = 0;            // how many have correct frequency in window

    var window = new Dictionary<char, int>();

    int left = 0, right = 0;
    int minLen = int.MaxValue;
    int minLeft = 0;

    while (right < s.Length)
    {
        char c = s[right];
        if (!window.ContainsKey(c))
            window[c] = 0;
        window[c]++;

        // Check if character's frequency matches requirement
        if (need.ContainsKey(c) && window[c] == need[c])
            formed++;

        // When window is valid, try to shrink it
        while (left <= right && formed == required)
        {
            int windowSize = right - left + 1;
            if (windowSize < minLen)
            {
                minLen = windowSize;
                minLeft = left;
            }

            char leftChar = s[left];
            window[leftChar]--;
            if (need.ContainsKey(leftChar) && window[leftChar] < need[leftChar])
                formed--;

            left++;
        }

        right++;
    }

    return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);

    }
}
