using System;
using System.Text;
using Algorthims.DataStructures;
namespace Algorthims.DataStructures
{
	public class LinkedList<T>
	{
		public ListNode<T> Head { get; set; }

		public  void ReverseLinkedList()
		{
			if (this.Head == null)
				return ;
			ListNode<T>? dummy = null; 
			ListNode<T> temp = this.Head;
			while(temp != null)
			{
                ListNode<T> node = temp.Next;
				temp.Next = dummy;
				dummy = temp;
				this.Head = temp;
				temp = node;
				
			}
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			ListNode<T> head = this.Head;
			while (head != null)
			{
				sb.Append(head.ToString() + " ");
				head = head.Next;
			}
			return sb.ToString();
		}
	}
}

