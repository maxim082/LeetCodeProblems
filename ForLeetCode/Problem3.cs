using System;
using System.Collections.Generic;
using System.Text;

namespace ForLeetCode
{
    class Problem3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var buffer = "";

            if (s.Length == 0) return 0;
            if (s.Length == 1) return 1;


            for (int i = 0; i < s.Length; i++)
            {
                if (!buffer.Contains(s[i]))
                {
                    buffer = String.Concat(buffer, s[i]);
                }
                else
                {
                    if (buffer.Length > result)
                    {
                        result = buffer.Length;
                    }

                    if (i != s.Length - 1)
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (s[k] == s[i])
                            {
                                i = k;
                                break;
                            }
                        }
                    buffer = "";
                }
            }

            if (buffer.Length > result) result = buffer.Length;

            return result;
        }
    }
}
