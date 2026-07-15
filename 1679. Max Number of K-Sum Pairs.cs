public class Solution {
    public int MaxOperations(int[] nums, int k) {
        // nums = [3, 5, 1, 5], k = 2
        // 1, 3, 5, 5
        if (nums.Length <= 1)
            return 0;

        Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;
        int answer = 0;

        while (right > left)
        {
            int sum = nums[left] + nums[right];

            if (sum == k)
            {
                answer += 1;
                left += 1;
                right -= 1;
            }
            else if (sum < k)
                left += 1;
            else
                right -= 1;
        }

        return answer;
    }
}