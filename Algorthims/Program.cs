using Algorthims.DataStructures;
using System;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestLinkedList();
        }

        static void TestLinkedList()
        {
            Algorthims.DataStructures.LinkedList<int> list = new Algorthims.DataStructures.LinkedList<int>();
            list.Head = new ListNode<int>(1);
            ListNode<int> head = list.Head;
            head.Next = new ListNode<int>(2);
            head.Next.Next = new ListNode<int>(3);
            ListNode<int> temp = head.Next.Next;
            temp.Next = new ListNode<int>(4);
            temp.Next.Next = new ListNode<int>(5);
            temp.Next.Next.Next = new ListNode<int>(6);
            Console.WriteLine(list);
            list.ReverseLinkedList();
            Console.WriteLine(list);
        }
    }
}