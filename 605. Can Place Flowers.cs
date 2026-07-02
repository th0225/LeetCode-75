public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            bool isLeftEmpty = i == 0 || flowerbed[i - 1] == 0;
            bool isRightEmpt = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;

            if (isLeftEmpty && isRightEmpt && flowerbed[i] == 0)
            {
                n -= 1;
                flowerbed[i] = 1;

                if (n == 0)
                    return true;
            }
        }

        return n <= 0;
    }
}