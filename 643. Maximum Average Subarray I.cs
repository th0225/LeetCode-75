public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double windowSum = 0;

        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }

        double maxSum = windowSum;
        // nums = [1, 12, -5, -6, 50, 3]
        for (int i = k; i < nums.Length; i++)
        {
            windowSum -= nums[i - k];
            windowSum += nums[i];

            if (windowSum > maxSum)
            {
                maxSum = windowSum;
            }
        }

        return maxSum / k;
    }
}