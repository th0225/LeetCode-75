public class Solution {
    public int MaxVowels(string s, int k) {
        // s = "a b c i i i d e f", k = 3
        int count = 0;

        // a b c
        for (int i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
            {
                count += 1;
            }
        }
        int max = count;

        // a/ b c i
        for (int i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k]))
                count -= 1;
            if (IsVowel(s[i]))
                count += 1;

            if (count > max)
                max = count;
        }

        return max;
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U';
    }
}