public class Solution {
    public bool IsSubsequence(string s, string t) {
        // s: abc, t: ahbdgc

        if (s.Length == 0)
            return true;

        int sIndex = 0;
        for (int i = 0; i < t.Length && sIndex < s.Length; i++)
        {
            if (t[i] == s[sIndex])
            {
                sIndex += 1;
            }
        }

        return sIndex == s.Length;
    }
}