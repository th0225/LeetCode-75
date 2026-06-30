public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int minLength = Math.Min(str1.Length, str2.Length);
        string pattern = str1.Substring(0, minLength);

        while (minLength > 0)
        {
            if (Compare(str1, pattern) && Compare(str2, pattern))
            {
                return pattern;
            }
            else
            {
                minLength -= 1;
                pattern = pattern.Substring(0, minLength);
            }
        }

        return string.Empty;
    }

    public static bool Compare(string str, string pattern)
    {
        if (str.Length % pattern.Length != 0)
            return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != pattern[i % pattern.Length])
                return false;
        }

        return true;
    }
}