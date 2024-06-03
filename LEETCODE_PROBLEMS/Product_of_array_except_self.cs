using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE_PROBLEMS
{
    internal class Product_of_array_except_self
    {
        public class Solution
        {
            public static int[] ProductExceptSelf(int[] nums)
            {
                int n = nums.Length;
                int[] prefixProducts = new int[n];
                int[] suffixProducts = new int[n];
                int[] answer = new int[n];

                for (int i = 0; i < n; i++)
                {
                    prefixProducts[i] = prefixProducts[i] * nums[i];
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    suffixProducts[i] = suffixProducts[i] * nums[i];
                }

                for (int i = 0; i < n; i++)
                {
                    answer[i] = prefixProducts[i] * suffixProducts[i];
                }

                return answer;
            }
        }
    }
}
