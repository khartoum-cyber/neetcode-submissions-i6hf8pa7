public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        int n = nums.Length;
        List<List<int>> triplets = new();
        HashSet<string> seen = new();

        for(int i = 0; i < n - 2; i++)
        {
            for(int j = i + 1; j < n - 1; j++)
            {
                for(int k = j + 1; k < n; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        int a = nums[i], b = nums[j], c = nums[k];
                        // normalize order by value to dedup (e.g., -1,-1,2)
                        var arr = new[] { a, b, c };
                        Array.Sort(arr);
                        string key = $"{arr[0]},{arr[1]},{arr[2]}";
                        if (seen.Add(key))
                            triplets.Add(new List<int> { arr[0], arr[1], arr[2] });
                    }
                }
            }
        }
        return triplets;
    }
}
