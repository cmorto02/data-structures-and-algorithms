using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList.classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        
        /// <summary>
        /// This method inserts a node at the head of the list with the value as a parameter of the method
        /// </summary>
        /// <param name="data">the value of the new node</param>
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
        /// <summary>
        /// This method creates an array of the values of the nodes in the linked list and returns that array
        /// </summary>
        /// <returns>array of the values of the nodes in the linked list</returns>
        public int[] Print()
        {
            int length = 0;
            Current = Head;
            while (Current != null)
            {
                length++;
                Current = Current.Next;
            }
            int[] allValues = new int[length];
            Current = Head;
            int i = 0;
            while (Current != null)
            {
                allValues[i] = Current.Value;
                i++;
                Current = Current.Next;
            }
            Console.WriteLine("[{0}]", string.Join(", ", allValues));
            return allValues;
        }
        /// <summary>
        /// checks to see if the input value is in the linked list
        /// </summary>
        /// <param name="data">the search value</param>
        /// <returns>true or false, whether the value is in the linked list or not</returns>
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
        /// <summary>
        /// Adds a value to the end of the linked list
        /// </summary>
        /// <param name="addValue">the value to add</param>
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
        /// <summary>
        /// inserts a node after a specified value that is searched
        /// </summary>
        /// <param name="searchValue">the value to search for in the list</param>
        /// <param name="addValue">the value you wish to add to the list</param>
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
        /// <summary>
        /// inserts a node with a specific value before a specified value in the linked list
        /// </summary>
        /// <param name="searchValue">the value to search</param>
        /// <param name="addValue">the value of the node you wish to add</param>
        public void InsertBefore(int searchValue, int addValue)
        {
            Current = Head;
            if (searchValue == Head.Value)
            {
                Node node = new Node
                {
                    Value = addValue,
                    Next = Head
                };

                Head = node;
                return;
            }
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
        /// <summary>
        /// returns the value of the node that is kth from the end of the list
        /// </summary>
        /// <param name="kth">the kth number from the end that you wish to have the value of</param>
        /// <returns>the node that is kth from the end</returns>
        public Node KthFromTheEnd(int kth)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
