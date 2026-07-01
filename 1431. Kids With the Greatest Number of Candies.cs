public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var isGreat = new List<bool>(candies.Length);
        int max = candies.Max();
        foreach (var candy in candies)
        {
            isGreat.Add((candy + extraCandies) >= max);
        }

        return isGreat;
    }
}