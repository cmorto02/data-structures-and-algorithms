using System;
using System.Collections.Generic;
using System.Text;
using stacksAndQueues.classes;

namespace queueWithStacks
{
    class PseudoQueue
    {
        Stack<int> main = new Stack<int>();
        Stack<int> temp = new Stack<int>();

        public void Enqueue(int value)
        {
            while ( main.Peek != null )
            {
                temp.Push(main.Pop());
            }
        }
        public void Dequeue()
        {

        }
    }
}
