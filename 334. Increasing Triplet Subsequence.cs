public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue;
        int second = int.MaxValue;

        // 2, 1, 5, 0, 4, 6 => 0, 4, 6
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= first)
            {
                first = nums[i];
            }
            else if (nums[i] <= second)
            {
                second = nums[i];
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}