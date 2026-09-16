public class TimeMap 
{
    private Dictionary<string, List<(int timestamp, string value)>> map;

    public TimeMap() 
    {
        map = new();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if(!map.ContainsKey(key))
        {
            map[key] = new();
        }

        map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) 
    {
        if (!map.ContainsKey(key))
            return "";

        var list = map[key];

        int l = 0;
        int r = list.Count - 1;
        string res = "";

        while(l <= r)
        {
            int mid = l + (r - l) / 2;
            
            if(list[mid].timestamp <= timestamp)
            {
                res = list[mid].value;
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return res;
    }
}