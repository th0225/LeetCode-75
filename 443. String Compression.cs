public class Solution {
    public int Compress(char[] chars) {
        int write = 0;
        int read = 0;

        while (read < chars.Length)
        {
            char current = chars[read];
            int count = 0;

            while (read < chars.Length && chars[read] == current)
            {
                read++;
                count++;
            }

            chars[write] = current;
            write++;

            if (count > 1)
            {
                foreach (char digit in count.ToString())
                {
                    chars[write] = digit;
                    write++;
                }
            }
        }

        return write;
    }
}