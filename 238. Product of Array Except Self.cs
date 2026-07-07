// public class Solution {
//     public int[] ProductExceptSelf(int[] nums) {
//         int[] answer = new int[nums.Length];
//         Array.Fill(answer, 1);

//         for (int i = 0; i < nums.Length; i++)
//         {
//             for (int j = 0; j < nums.Length; j++)
//             {
//                 if (j == i)
//                     continue;

//                 answer[i] *= nums[j];
//             }
//         }

//         return answer;
//     }
// }


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }

        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
        }

        return answer;
    }
}