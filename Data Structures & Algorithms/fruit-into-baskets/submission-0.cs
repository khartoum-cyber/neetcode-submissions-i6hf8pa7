public class Solution 
{
    public int TotalFruit(int[] fruits) 
    {
        Dictionary<int, int> counts = new();

        int left = 0;
        int maxLen = 0;

        for(int right = 0; right < fruits.Length; right++)
        {
            counts[fruits[right]] = counts.GetValueOrDefault(fruits[right], 0) + 1;

            while(counts.Count > 2)
            {
                counts[fruits[left]]--;
                if(counts[fruits[left]] == 0)
                    counts.Remove(fruits[left]);
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}