using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LEETCODE_PROBLEMS
{
    internal class Top_K_Frequent_Elements
    {
        public class Solution
        { 
            public static int[] TopKFrequent(int[] nums, int k)
            {
                Dictionary<int, int> dict = new();
                PriorityQueue<int, int> queue = new();
                int[] result = new int[k];

                foreach (int num in nums)
                {
                    if (!dict.ContainsKey(num))
                        dict[num] = 0;
                    dict[num]++;
                }

                foreach(var (key, value) in dict)
                {
                    queue.Enqueue(key, -value);
                }

                for(int i=0; i<k; i++)
                {
                    result[i] = queue.Dequeue();
                }

                return result;
            }
        }

        public class Solution2
        {
            public int[] TopKFrequent(int[] nums, int k)
            {
                int[] result = new int[k];
                int count = 0;

                Dictionary<int, int> dict = [];

                foreach (int num in nums)
                {
                    if (!dict.ContainsKey(num))
                        dict[num] = 0;

                    dict[num] += 1;
                }

                for (int max = dict.Values.Max(); max >= 0; max--)
                {
                    foreach (var (key, value) in dict)
                    {
                        if (value == max)
                        {
                            result[count++] = key;
                            if (count == k)
                                break;
                        }
                    }

                    if (count == k)
                        break;
                }

                return result;
            }
        }
    }
}
