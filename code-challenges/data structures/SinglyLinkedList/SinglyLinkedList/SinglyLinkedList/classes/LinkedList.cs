using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList.classes
{
    class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert (int data)
        {
            try
            {
                Node node = new Node
                {
                    Value = data,
                    Next = Head
                };

                Head = node;


            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the value as a number");

                throw;
            }
        }
        public void printAllNodes()
        {
            Current = Head;
            while (Current != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
        }
        
        public bool Includes(int data)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == data)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }

    }
}
