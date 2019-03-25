using SinglyLinkedList.classes;
using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newLink = new LinkedList();
            newLink.AddFirst(4);
            newLink.AddFirst(345);
            newLink.AddFirst(645373545);
            newLink.printAllNodes();
        }
    }
}



// 
