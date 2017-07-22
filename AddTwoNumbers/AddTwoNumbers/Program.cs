using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode r = AddTwoNumbers(l1, l2);
            printList(r);
            Console.Read();
            ListNode l3 = new ListNode(9);
            l3.next = new ListNode(9);
            ListNode l4 = new ListNode(8);
            ListNode r2 = AddTwoNumbers(l3, l4);
            printList(r2);
            Console.Read();
        }

        private static void printList(ListNode r)
        {
            while (r != null)
            {
                Console.Write(r.val + " ");
                r = r.next;
            }

        }


            public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int len1 = Length(l1);
            int len2 = Length(l2);
            ListNode smallList = l1;
            ListNode bigList = l2;
            if (len1 > len2)
            {
                bigList = l1;
                smallList = l2;
            }
            PadList(smallList, Math.Abs(len1 - len2));
            int carry = 0;
            ListNode prevNode = null;
            ListNode tempNode = null;
            ListNode resultNode = tempNode;
            Stack<int> stack= new Stack<int>();
            for (int i = 0; i < Math.Max(len1, len2); i++)
            {
                int c = bigList.val + smallList.val + carry;
                carry = 0;
                if (c >= 10)
                {
                    c = c % 10;
                    carry = 1;
                }
                stack.Push(c);
                tempNode = new ListNode(c);
                if (prevNode != null)
                {
                    prevNode.next = tempNode;
                }
                prevNode = tempNode;
                bigList = bigList.next;
                smallList = smallList.next;
            }
            int msd = carry;
            ListNode nextNode = msd == 1 ? new ListNode(1) : null;
            while (stack.Count > 0)
            {
                int c = stack.Pop();
                ListNode newNode = new ListNode(c);
                newNode.next = nextNode; 
                nextNode = newNode;
            }
            return nextNode;
        }

        private static void PadList(ListNode l, int d)
        {
            ListNode t = l;
            while (t.next != null)
            {
                t = t.next;
            }
            int c = 0;
            while (c < d)
            {
                t.next = new ListNode(0);
                t = t.next;
                c++;
            }
        }

        private static int Length(ListNode n)
        {
            int count = 0;
            ListNode root = n;
            while (root != null)
            {
                count++;
                root = root.next;
            }
            return count;
        }



    }


}
