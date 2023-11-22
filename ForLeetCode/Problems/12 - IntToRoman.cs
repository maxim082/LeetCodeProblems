using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public static class IntToRoman
    {
        public static string Calculate(int num)
        {
            //2495 = "MMCDXCV"
            if (num < 1 || num > 3999)
            {
                throw new Exception("Число находится за пределами заданного промежутка");
            }

            var dict = new Dictionary<int, char>()
            {
                { 1, 'I'},
                { 5, 'V'},
                { 10, 'X'},
                { 50, 'L'},
                { 100, 'C'},
                { 500, 'D'},
                { 1000, 'M'}
            };

            var result = new StringBuilder();
            int counter = 1000;

            while (counter > 0)
            {
                int item = num / counter;

                if (item < 4 && item > 0)
                {
                    result.Append(dict.GetValueOrDefault(counter), item);
                }
                if (item == 4)
                {
                    result.Append(dict.GetValueOrDefault(counter));
                    result.Append(dict.GetValueOrDefault(counter * 5));
                }
                if (item == 5)
                {
                    result.Append(dict.GetValueOrDefault(counter * 5));
                }
                if (item < 9 && item > 5)
                {
                    result.Append(dict.GetValueOrDefault(counter * 5));
                    result.Append(dict.GetValueOrDefault(counter), item - 5);
                }
                else if (item == 9)
                {
                    result.Append(dict.GetValueOrDefault(counter));
                    result.Append(dict.GetValueOrDefault(counter * 10));               
                }

                num = num % counter;
                counter = counter / 10;
            }

            return result.ToString();
        }
    }
}

