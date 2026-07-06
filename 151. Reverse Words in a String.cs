// public class Solution {
//     public string ReverseWords(string s) {
//         var sList = s.Split(" ");
//         var sb = new StringBuilder();
//         for (int i = sList.Length - 1; i >= 0; i--)
//         {
//             if (!string.IsNullOrWhiteSpace(sList[i]))
//             {
//                 sb.Append(sList[i]);
//                 sb.Append(" ");
//             }
//         }

//         if (sb.Length > 0)
//         {
//             sb.Remove(sb.Length - 1, 1);
//         }

//         return sb.ToString();
//     }
// };

// public class Solution
// {
//     public string ReverseWords(string s)
//     {
//         var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//         var sb = new StringBuilder();

//         for (int i = words.Length - 1; i >= 0; i--)
//         {
//             sb.Append(words[i]);

//             if (i > 0)
//                 sb.Append(' ');
//         }

//         return sb.ToString();
//     }
// }

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words =
            s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(" ", words);
    }
}