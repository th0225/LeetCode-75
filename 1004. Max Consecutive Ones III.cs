public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int zeroCnt = 0;
        int max = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                zeroCnt++;
            }

            while (zeroCnt > k)
            {
                if (nums[left] == 0)
                {
                    zeroCnt--;
                }

                left++;
            }

            int length = right - left + 1;
            max = Math.Max(max, length);
        }

        return max;
    }
}