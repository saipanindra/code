using System;

namespace Merge2SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(1);
           ListNode r = MergeTwoLists(l1, l2);

        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if(l1 == null) return l2;
            if(l2 == null) return l1;

            if(l1.val > l2.val)
            {
                ListNode temp = l1;
                l1 = l2;
                l2 = temp;
            }

            ListNode head = l1;

            while(l1.next != null & l2 != null)
            {
                if(l1.next.val < l2.val)
                {
                    l1 = l1.next;
                }
                else
                {
                    ListNode n = l1.next;
                    ListNode t = l2.next;
                    l1.next = l2;
                    l2.next = n;
                    l1 = l2;
                    l2 = t;
                }
            }
            if(l1.next == null) 
               l1.next = l2;
            return head;
        }

        
    }
}
