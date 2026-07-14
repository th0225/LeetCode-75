public class Solution {
    public int MaxArea(int[] height) {
        // [1,8,6,2,5,4,8,3,7]
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int area = Math.Min(height[left], height[right]) * (right - left);
            if (area > maxArea)
                maxArea = area;
            if (height[left] < height[right])
                left += 1;
            else if (height[left] > height[right])
                right -= 1;
            else if (height[left] == height[right])
                left += 1;
        }

        return maxArea;
    }
}