using System;
using System.Collections.Generic;

namespace try3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public LinkedListNode<int> Partition(LinkedListNode<int> head, int x)
        {
            LinkedListNode<int> partition;
            LinkedListNode<int> current = head;
            while (current.Value != x)
            {
                current = current.Next;
            }
            partition = current;
            LinkedListNode<int> testCurrent = head;
            while (testCurrent != null)
            {
                if (testCurrent.Value > partition.Value)
                {
                    head = testCurrent.Next;
                    
                }
            }
            return head;
        }
    }
}
