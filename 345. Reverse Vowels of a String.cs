// public class Solution
// {
//     public string ReverseVowels(string s)
//     {
//         char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
//         char[] sChar = s.ToCharArray();

//         int k = s.Length - 1;

//         for (int i = 0; i < s.Length - 1; i++)
//         {
//             var front = s[i];

//             if (vowels.Contains(front))
//             {
//                 for (int j = k; j > i; j--)
//                 {
//                     var back = s[j];
//                     if (vowels.Contains(back))
//                     {
//                         sChar[j] = front;
//                         sChar[i] = back;

//                         k = j - 1;
//                         break;
//                     }
//                 }
//             }

//             if (i >= k)
//                 break;
//         }

//         return new string(sChar);
//     }
// }

public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            while (left < right && !IsVowel(chars[left]))
                left++;

            while (left < right && !IsVowel(chars[right]))
                right--;

            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++;
            right--;
        }

        return new string(chars);
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U';
    }
}