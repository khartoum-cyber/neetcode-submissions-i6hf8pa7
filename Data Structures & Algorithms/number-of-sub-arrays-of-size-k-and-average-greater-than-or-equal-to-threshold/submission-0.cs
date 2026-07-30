public class Solution 
{
    public int NumOfSubarrays(int[] arr, int k, int threshold) 
    {
        int count = 0;
        int currSum = 0;

        for(int i = 0; i < k; i++)
        {
            currSum += arr[i];
        }

        if((currSum / k) >= threshold)
            count++;

        for(int i = k; i < arr.Length; i++)
        {
            currSum += arr[i] - arr[i - k];

            if((currSum / k) >= threshold)
                count++;
        }

        return count; 
    }
}