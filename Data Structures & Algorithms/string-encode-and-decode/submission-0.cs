public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs.Count == 0)
            return string.Empty;
        
        List<int> sizesList = new(strs.Count);

        foreach(var str in strs)
        {
            sizesList.Add(str.Length);
        }

        StringBuilder sb = new();

        sb.Append(string.Join(',', sizesList));
        sb.Append('#');

        foreach(var str in strs)
        {
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        if(string.IsNullOrEmpty(s))
            return new List<string>();
        
        List<int> sizes = new List<int>();
        List<string> res = new List<string>();
        
        int i = 0;
        while (s[i] != '#') {
            string cur = "";
            while (s[i] != ',' && s[i] != '#') {
                cur += s[i];
                i++;
            }
            sizes.Add(int.Parse(cur));
            if (s[i] == ',') i++;
        }
        i++;

        foreach (int sz in sizes) {
            res.Add(s.Substring(i, sz));
            i += sz;
        }
        return res;
    }
}
