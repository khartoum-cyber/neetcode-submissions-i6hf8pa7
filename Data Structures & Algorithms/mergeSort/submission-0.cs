// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution 
{
public List<Pair> MergeSort(List<Pair> pairs)
{
    if (pairs.Count <= 1)
        return pairs;

    int mid = pairs.Count / 2;

    List<Pair> left = MergeSort(pairs.GetRange(0, mid));
    List<Pair> right = MergeSort(pairs.GetRange(mid, pairs.Count - mid));

    return Merge(left, right);
}

private List<Pair> Merge(List<Pair> left, List<Pair> right)
{
    List<Pair> result = new List<Pair>();

    int l = 0;
    int r = 0;

    while (l < left.Count && r < right.Count)
    {
        if (left[l].Key <= right[r].Key)
        {
            result.Add(left[l]);
            l++;
        }
        else
        {
            result.Add(right[r]);
            r++;
        }
    }

    while (l < left.Count)
    {
        result.Add(left[l]);
        l++;
    }

    while (r < right.Count)
    {
        result.Add(right[r]);
        r++;
    }

    return result;
}

}
