using SinglyLinkedList.classes;
using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newLink = new LinkedList();
            newLink.Insert(4);
            newLink.Insert(345);
            newLink.Insert(645373545);
            newLink.printAllNodes();

            Console.WriteLine("Please entere a number for the new node");
            string newInt = Console.ReadLine();
            int nodeValue = Convert.ToInt32(newInt);
            newLink.Insert(nodeValue);
            newLink.printAllNodes();

            Console.WriteLine("Please entere a number to search.");
            string searchString = Console.ReadLine();
            int searchInt = Convert.ToInt32(searchString);
            bool printThis = newLink.Includes(searchInt);
            Console.WriteLine(printThis);
        }
    }
}



// 
