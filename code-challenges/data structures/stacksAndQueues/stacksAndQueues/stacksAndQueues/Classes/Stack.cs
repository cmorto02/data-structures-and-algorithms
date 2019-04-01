using stacksAndQueues.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace stacksAndQueues
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }
        public Node<T> Current { get; set; }
        public void Push(T data)
        {
            Node<T> node = new Node<T>
            {
                Value = data,
                Next = Top
            };
            Top = node;
        }
        public Node<T> Pop()
        {
            Node<T> node = Top;
            Top = Top.Next;
            node.Next = null;
            return node;
        }
        public T Peek()
        {
            return Top.Value;
        }
    }
}
