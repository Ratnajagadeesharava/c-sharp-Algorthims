using System;
namespace Algorthims.DataStructures
{
	public class ListNode<T>
	{
		public ListNode<T> Next { get; set; }
		public T Value { get; set; }
		public ListNode(T Value)
		{
			this.Value = Value;
		}
		public override string ToString()
		{
			return Value.ToString();
		}
	}
}

