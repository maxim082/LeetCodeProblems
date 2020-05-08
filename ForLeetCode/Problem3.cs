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

            for (int k = 0; k < s.Length; k++)
            {
                for (int i = k; i < s.Length; i++)
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
                        buffer = "";
                        break;
                    }
                }
            }
            if (buffer.Length > result) result = buffer.Length;

            return result;
        }
    }
}
