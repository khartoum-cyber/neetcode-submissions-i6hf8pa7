// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs)
    {
        List<List<Pair>> res = new List<List<Pair>>();

        if(pairs.Count == 0)
            return res;

        res.Add(new List<Pair>(pairs));

        for (int i = 1; i < pairs.Count; i++)
        {
            int j = i;

            while (j > 0 && pairs[j].Key < pairs[j - 1].Key)
            {
                Swap(pairs, j, j - 1);
                j--;
            }

            res.Add(new List<Pair>(pairs));
        }
        return res;
    }

    private static void Swap(List<Pair> pairs, int first, int second)
    {
        Pair temp = pairs[first];
        pairs[first] = pairs[second];
        pairs[second] = temp;
    }
}
