using System;
using System.Collections.Generic;
using System.Text;

namespace ForLeetCode
{
    class Problem2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var resultList = new List<int>();
            int flag = 0;

            while (l1 != null || l2 != null)
            {
                var num = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + flag;
                flag = num / 10;
                num = num % 10;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                resultList.Add(num);
            }
            if (flag > 0) resultList.Add(1);

            l1 = null;
            for (int i = resultList.Count - 1; i >= 0; i--)
            {
                l1 = new ListNode(resultList[i], l1);
            }
            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
