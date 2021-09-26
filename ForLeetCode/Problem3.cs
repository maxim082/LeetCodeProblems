using System;

namespace ForLeetCode
{
    public static class Problem3
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var buffer = "";
            var num = 0;

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

                    i = num + buffer.IndexOf(s[i]);
                    num = i + 1;
                    buffer = "";
                }
            }

            if (buffer.Length > result) result = buffer.Length;

            return result;
        }
    }
}
