public class Solution 
{
    public int[] CountBits(int n) 
    {
        int[] arr = new int[n + 1];

        for(int i = 0; i <= n; i++)
        {
            int temp = i;
            int count = 0;

            while(temp > 0)
            {
                if((temp & 1) == 1)
                    count++;
                
                temp = temp >> 1;
            }

            arr[i] = count;
        }

        return arr;
    }
}
