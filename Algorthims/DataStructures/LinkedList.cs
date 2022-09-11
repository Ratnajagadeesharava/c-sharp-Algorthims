using System;
using Algorthims.DataStructures;
namespace Algorthims.DataStructures
{
	public class LinkedList<T>
	{
		public ListNode<T>? Head { get; set; }

		public static ListNode<T> ReverseLinkedList(ListNode<T> head)
		{
			if (head != null)
				return head;
			ListNode<T> dummy = null; 
			ListNode<T> temp = head;
			
			while (temp != null)
			{
				
				ListNode<T> temp1 = temp.Next;
				temp.Next = dummy;
				dummy = temp;
				temp = temp1;
				
			}

			return head;
		}
	}
}

