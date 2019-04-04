using stacksAndQueues.classes;
using System;

namespace stacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            Console.WriteLine(queue.Front.Value);
        }
    }
}
