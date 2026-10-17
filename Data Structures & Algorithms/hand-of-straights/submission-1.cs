public class Solution 
{
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        if(hand.Length % groupSize != 0)
            return false;

        Dictionary<int,int> count = new();

        foreach(var num in hand)
        {
            count[num] = count.GetValueOrDefault(num, 0) + 1;
        }

        Array.Sort(hand);

        foreach(var num in hand)
        {
            if(count[num] > 0)
            {
                for(int i = num; i < num + groupSize; i++)
                {
                    if(!count.ContainsKey(i) || count[i] == 0)
                    {
                        return false;
                    }

                    count[i]--;
                }
            }
        }

        return true;
    }
}
