public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string,List<string>> map = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                string key = ToVector(s);

                if(!map.TryGetValue(key, out var list))
                    map[key] = list = new List<string>();

                list.Add(s);
            }

            return map.Values.ToList();
        }

        private string ToVector(string input)
        {
            if (input.Length == 0)
                return "";

            int[] counts = new int[26];

            foreach (char c in input)
                counts[c - 'a']++;

            return string.Join(",", counts);
        }
}
