using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE_PROBLEMS
{
    internal class Contains_duplicate
    {
        public class Solution
        {
            public static bool ContainsDuplicate(int[] nums)
            {
                var hash = new HashSet<int>();

                foreach (var num in nums)
                {
                    if (hash.Contains(num))
                        return true;

                    hash.Add(num);
                }

                return false;
            }
        }
    }
}
