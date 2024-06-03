using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE_PROBLEMS
{
    internal class Valid_anagram
    {
        public class Solution
        {
            public static bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length)
                    return false;

                Dictionary<char, int> hashS = [], hashT = [];

                for(int i=0; i<s.Length; i++)
                {
                    hashS[s[i]] = 1 + (hashS.TryGetValue(s[i], out int sVal) ? sVal : 0);

                    hashT[t[i]] = 1 + (hashT.TryGetValue(t[i], out int tVal) ? tVal : 0);
                }

                foreach(var (c, sVal) in hashS)
                {
                    if (hashT.TryGetValue(c, out int tVal))
                    {
                        if (sVal != tVal)
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
