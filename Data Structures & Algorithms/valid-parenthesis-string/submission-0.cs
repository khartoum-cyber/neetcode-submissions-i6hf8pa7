public class Solution 
{
    public bool CheckValidString(string s) 
    {
        int leftMin = 0, leftMax = 0;

        foreach(var ch in s)
        {
            if(ch == '(')
            {
                leftMin++;
                leftMax++;
            }
            else if(ch == ')')
            {
                leftMin--;
                leftMax--;
            }
            else
            {
                leftMin--;
                leftMax++;
            }

            if(leftMax < 0)
            {
                return false;
            }

            if(leftMin < 0)
            {
                leftMin = 0;
            }
        }

        return leftMin == 0;
    }
}
