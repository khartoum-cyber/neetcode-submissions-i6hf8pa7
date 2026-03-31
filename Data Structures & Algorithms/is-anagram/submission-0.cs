public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        string sorted1 = new string(s.OrderBy(c => c).ToArray());
        string sorted2 = new string(t.OrderBy(c => c).ToArray());

        return sorted1 == sorted2;
    }
}
