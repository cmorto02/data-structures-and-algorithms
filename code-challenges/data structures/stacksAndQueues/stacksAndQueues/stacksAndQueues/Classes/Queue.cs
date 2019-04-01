using System;
using System.Collections.Generic;
using System.Text;

namespace stacksAndQueues.classes
{
    class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Current { get; set; }
        public Node<T> Rear { get; set; }
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>
            {
                Value = data,
                Next = null
            };
            Rear.Next = node;
        }
        public Node<T> Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
        public T Peek()
        {
            return Front.Value;
        }
    }
}
