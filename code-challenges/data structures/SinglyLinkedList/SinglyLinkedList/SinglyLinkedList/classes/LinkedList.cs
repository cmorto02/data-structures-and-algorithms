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

        public void Append(int addValue)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node node = new Node
            {
                Value = addValue,
                Next = null
            };
            Current.Next = node;
        }

        public void InsertAfter(int searchValue, int addValue)
        {
            Current = Head;
            while (Current.Value != searchValue)
            {
                Current = Current.Next;
            }
            Node newNode = new Node
            {
                Value = addValue,
                Next = Current.Next
            };
            Current.Next = newNode;
        }
        public void InsertBefore(int searchValue, int addValue)
        {
            Current = Head;
            while (Current.Next.Value != searchValue)
            {
                Current = Current.Next;
            }
            Node newNode = new Node
            {
                Value = addValue,
                Next = Current.Next
            };
            Current.Next = newNode;
        }
        public Node KthFromTheEnd(int kth)
        {
            Current = Head;
            int amountOfNodes = 1;
            while (Current.Next != null)
            {
                amountOfNodes++;
                Current = Current.Next;
            }
            int nodeNumber = 1;
            Current = Head;
            while (nodeNumber != (amountOfNodes - kth))
            {
                nodeNumber++;
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
            return Current;
        }
    }
}
