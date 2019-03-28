using SinglyLinkedList.classes;
using System;

namespace SinglyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList newLink = new LList();
            newLink.Insert(4);
            newLink.Insert(345);
            newLink.Insert(645373545);
            newLink.PrintAllNodes();

            Console.WriteLine("Please entere a number for the new node");
            string newInt = Console.ReadLine();
            int nodeValue = Convert.ToInt32(newInt);
            newLink.Insert(nodeValue);
            newLink.PrintAllNodes();

            Console.WriteLine("Please entere a number to search.");
            string searchString = Console.ReadLine();
            int searchInt = Convert.ToInt32(searchString);
            bool printThis = newLink.Includes(searchInt);
            Console.WriteLine(printThis);



            Console.WriteLine("Please entere a number to append.");
            string addString = Console.ReadLine();
            int addInt = Convert.ToInt32(addString);
            newLink.Append(addInt);
            Console.WriteLine("");
            Console.WriteLine("");
            newLink.PrintAllNodes();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please entere a number to add.");
            string newAddString = Console.ReadLine();
            int newAddInt = Convert.ToInt32(newAddString);
            Console.WriteLine("Please entere a number to search.");
            string newSearch = Console.ReadLine();
            int newSearchInt = Convert.ToInt32(newSearch);
            newLink.InsertAfter(newSearchInt, newAddInt);

            Console.WriteLine("");
            Console.WriteLine("");
            newLink.PrintAllNodes();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please entere a number to add.");
            string addAfterString = Console.ReadLine();
            int addAfterInt = Convert.ToInt32(addAfterString);
            Console.WriteLine("Please entere a number to search.");
            string addAfterSearchString = Console.ReadLine();
            int addAfterSearchInt = Convert.ToInt32(addAfterSearchString);
            newLink.InsertBefore(addAfterSearchInt, addAfterInt);

            Console.WriteLine("");
            Console.WriteLine("");
            newLink.PrintAllNodes();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please entere the node you want to get to.");
            string nodeNumberString = Console.ReadLine();
            int nodeNumberInt = Convert.ToInt32(nodeNumberString);
            newLink.KthFromTheEnd(nodeNumberInt);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}



// 
