using System;
using System.Collections.Generic;
using System.Linq;

namespace ForLeetCode
{
    class Program
    {
        private static Problem1 _problem1 = new Problem1();
        private static Problem2 _problem2 = new Problem2();
        private static Problem3 _problem3 = new Problem3();

        static void Main(string[] args)
        {
            var result = _problem3.LengthOfLongestSubstring("pwwkew");
            Console.WriteLine("Test Application");
        }         
    }
}
