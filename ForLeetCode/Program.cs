using System;
using System.Collections.Generic;
using System.Linq;

namespace ForLeetCode
{
    class Program
    {
        private static Problem1 _problem1 = new Problem1();
        private static Problem2 _problem2 = new Problem2();

        static void Main(string[] args)
        {
            var result = _problem2.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3, null))), new ListNode(5, new ListNode(6, new ListNode(4, null))));
            Console.WriteLine("Hello World!");
        }         
    }
}
