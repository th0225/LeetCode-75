public class Solution {
    public void MoveZeroes(int[] nums) {
        // [0, 1, 0, 3, 12]

        int writeIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[writeIndex] = nums[i];
                writeIndex += 1;
            }
        }

        for (int i = writeIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}