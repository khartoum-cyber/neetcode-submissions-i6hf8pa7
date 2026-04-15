public class Solution {
    public List<List<int>> Combine(int n, int k) 
    {
        var res = new List<List<int>>();
        var subset = new List<int>();
        RecCombine(subset, 1, n, k, res);
        return res;
    }

    private void RecCombine(List<int> subset, int start, int n, int k, List<List<int>> res)
    {
        if(subset.Count == k)
        {
            res.Add(new List<int>(subset));
            return;
        }

        for(int i = start; i <= n; i++)
        {
            subset.Add(i);
            RecCombine(subset, i + 1, n, k, res);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}