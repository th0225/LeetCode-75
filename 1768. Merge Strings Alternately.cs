using System.Text;

public class Solution
{
    // public string MergeAlternately(string word1, string word2)
    // {
    //     var output = new StringBuilder(word1.Length + word2.Length);

    //     int length = Math.Max(word1.Length, word2.Length);
    //     for (int i = 0; i < length; i++)
    //     {
    //         if (i < word1.Length)
    //             output.Append(word1[i]);
    //         if (i < word2.Length)
    //             output.Append(word2[i]);
    //     }

    //     return output.ToString();
    // }

    public string MergeAlternately(string word1, string word2)
    {
        var output = new StringBuilder(word1.Length + word2.Length);
        int i = 0;
        int j = 0;

        while (i < word1.Length && j < word2.Length)
        {
            output.Append(word1[i]).Append(word2[j]);
            i++;
            j++;
        }

        while (i < word1.Length)
        {
            output.Append(word1[i]);
            i++;
        }

        while (j < word2.Length)
        {
            output.Append(word2[j]);
            j++;
        }

        return output.ToString();
    }
}
