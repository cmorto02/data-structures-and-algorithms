using stacksAndQueues;
using stacksAndQueues.classes;
using System;
using System.Text;

namespace queueWithStacks
{
    public class PseudoQueue
    {
        public Stack<int> Main { get; set; }
        public Stack<int> Temp { get; set; }

        public PseudoQueue()
        {
            Main = new Stack<int>();
            Temp = new Stack<int>();
        }
        public void Enqueue(int data)
        {
            while (Main.Top != null)
            {
                Node<int> moving = Main.Pop();
                Temp.Push(moving.Value);
            }
            Main.Push(data);
            while (Temp.Top != null)
            {
                Node<int> moving = Temp.Pop();
                Main.Push(moving.Value);
            }
        }
        public void Dequeue()
        {
            Main.Pop();
        }
    }
}
