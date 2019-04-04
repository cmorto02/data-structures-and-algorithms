using System;
using System.Collections.Generic;
using System.Text;

namespace stacksAndQueues.classes
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Current { get; set; }
        public Node<T> Rear { get; set; }

        public void Enqueue(T data)
        {
            
            Node<T> node = new Node<T>
            {
                Value = data,
            };
            if (Front == null)
            {
                Front = node;
            }
            if (Rear == null)
            {
                Rear = node;
            }
            Rear.Next = node;
            Rear = node;
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
