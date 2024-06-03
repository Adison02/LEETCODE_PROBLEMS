using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE_PROBLEMS
{
    internal class Two_sum
    {
        public class Solution
        {
            public static int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> hash = [];

                for(int i=0; i<nums.Length; i++)
                {
                    int r = target - nums[i];

                    if(hash.TryGetValue(r, out int value))
                    {
                        return [value, i];
                    }
                    else
                    {
                        hash[nums[i]] = i;
                    }
                }

                return default;
            }
        }
    }
}
