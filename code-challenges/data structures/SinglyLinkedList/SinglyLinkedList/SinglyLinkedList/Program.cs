using SinglyLinkedList.classes;
using System;

namespace SinglyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList newLink = new LList();
            Console.WriteLine("Inserting 6 and 4.");
            newLink.Insert(6);
            newLink.Insert(4);
            newLink.Print();

            Console.WriteLine();
            Console.WriteLine("Printing an array of the current values of the nodes.");
            newLink.Print();

            Console.WriteLine();
            Console.WriteLine("InsertBefore(4, 3)");
            newLink.InsertBefore(4, 3);
            newLink.Print();

            Console.WriteLine();
            Console.WriteLine("InsertAfter(4, 7)");
            newLink.InsertAfter(4,7);
            newLink.Print();

            Console.WriteLine();
            Console.WriteLine("Append(9)");
            newLink.Append(9);
            newLink.Print();

            Console.WriteLine();
            Console.WriteLine("Includes(7)");
            bool truth = newLink.Includes(7);
            string newTruth = Convert.ToString(truth);
            newLink.Print();
            Console.WriteLine(newTruth);

            Console.WriteLine();
            Console.WriteLine("KthFromTheEnd(2)");
            newLink.KthFromTheEnd(2);
            newLink.Print();

        }
    }
}



// 
