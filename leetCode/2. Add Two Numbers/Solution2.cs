using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2._Add_Two_Numbers
{
	public class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int val=0, ListNode next=null) 
		{
			this.val = val;
			this.next = next;
		}
	}

	public class Solution2
	{
		public Solution2()
		{
			// Create the input lists
			ListNode l1 = new ListNode(1);
			l1.next = new ListNode(0);
			l1.next.next = new ListNode(0);
			// ... continue adding nodes with value 0
			l1.next.next.next = new ListNode(0);
			l1.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(0);
			l1.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next.next = new ListNode(1);

			ListNode l2 = new ListNode(5);
			l2.next = new ListNode(6);
			l2.next.next = new ListNode(4);

			// Call the function to add the two numbers
			ListNode result = AddTwoNumbers(l1, l2);

			// Print the result
			PrintLinkedList(result);
		}

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			int carry = 0;
			ListNode dummy = new ListNode(0);
			ListNode current = dummy;

			while (l1 != null || l2 != null || carry != 0)
			{
				int sum = carry;

				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}

				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}

				int digit = sum % 10;
				carry = sum / 10;

				current.next = new ListNode(digit);
				current = current.next;
			}

			return dummy.next;
		}

		public static void PrintLinkedList(ListNode head)
		{
            Console.WriteLine("Solution 2: ");
            ListNode current = head;
			while (current != null)
			{
				Console.Write(current.val);
				if (current.next != null)
					Console.Write(" -> ");
				current = current.next;
			}
			Console.WriteLine();
		}
	}
}
