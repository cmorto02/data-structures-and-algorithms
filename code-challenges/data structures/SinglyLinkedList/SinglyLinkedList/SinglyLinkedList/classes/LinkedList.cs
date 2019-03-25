using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList.classes
{
    class LinkedList
    {
        public Node Head { get; set; }
        public void AddFirst (int data)
        {
            Node add = new Node
            {
                value = data,
                next = Head
            };

            Head = add;
        }
        public void printAllNodes()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        public void Insert(int value)
        {
            try
            {


            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the value as a number");

                throw;
            }
        }
        public void Includes()
        {
            Node addNode = new Node
        }

    }
}
