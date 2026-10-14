public class Solution 
{
    public bool LemonadeChange(int[] bills) 
    {
        int fives = 0;
        int tens = 0;

        foreach(var bill in bills)
        {
            if(bill == 5)
            {
                fives++;
            }
            else if(bill == 10)
            {
                tens++;

                if(fives > 0)
                {
                    fives--;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int change = bill - 5;

                if(change == 15 && fives > 0 && tens > 0)
                {
                    fives--;
                    tens--;
                }
                else if(change == 15 && fives >= 3)
                {
                    fives -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}