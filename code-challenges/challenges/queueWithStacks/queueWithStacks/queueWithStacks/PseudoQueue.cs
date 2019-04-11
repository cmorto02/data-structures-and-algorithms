using stacksAndQueues;
using stacksAndQueues.classes;
using System;
using System.Text;

namespace queueWithStacks
{
    public class PseudoQueue
    {
        public Stack<int> Front { get; set; }
        public Stack<int> Back { get; set; }
       

        public PseudoQueue()
        {
            Front = new Stack<int>();
            Back = new Stack<int>();
        }
        /// <summary>
        /// This pushes a node into the "back" of the pseudoqueue
        /// </summary>
        /// <param name="data">the node value data(int)</param>
        public void Enqueue(int data)
        {
            Back.Push(data);
        }
        /// <summary>
        /// This moves all of he back into the front of the queue if the front is empty, and then removes the "front" node from the pseudoqueue
        /// </summary>
        /// <returns>Returns the dequeued value(int)</returns>
        public int Dequeue()
        {
            if (Front.Top == null)
            {
                while (Back.Top != null)
                {
                    int moving = Back.Pop().Value;
                    Front.Push(moving);
                }
            }
            return Front.Pop().Value;
        }
    }
}
