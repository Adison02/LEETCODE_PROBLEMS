using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE_PROBLEMS
{
    internal class Group_anagrams
    {
        public class Solution
        {
            public static IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, List<string>> dict = [];

                foreach(var str in strs)
                {
                    char[] ch = str.ToCharArray();
                    Array.Sort(ch);
                    string keyStr = new(ch);

                    if(!dict.ContainsKey(keyStr))
                    {
                        dict[keyStr] = [];
                    }

                    dict[keyStr].Add(str);
                }

                return new List<IList<string>>(dict.Values);
            }
        }
    }
}
