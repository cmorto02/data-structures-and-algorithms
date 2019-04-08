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
        /// <summary>
        /// Method adds nodes to the end of the queue
        /// </summary>
        /// <param name="data">this is the data that goes into the node</param>
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
        /// <summary>
        /// This method removes a node from the front of the queue
        /// </summary>
        /// <returns>Returns the dequeued node</returns>
        public Node<T> Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
        /// <summary>
        /// This method checks the value of the front node of the queue
        /// </summary>
        /// <returns>Returns the value of the front node.</returns>
        public T Peek()
        {
            return Front.Value;
        }
    }
}
