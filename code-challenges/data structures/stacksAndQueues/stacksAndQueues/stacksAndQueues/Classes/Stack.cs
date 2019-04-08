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
        /// <summary>
        /// This method adds a node to the top of the stack
        /// </summary>
        /// <param name="data">This is the information that goes into the node</param>
        /// <returns>Returns the new top of the stack.</returns>
        public Node<T> Push(T data)
        {
            Node<T> node = new Node<T>
            {
                Value = data,
                Next = Top
            };
            Top = node;
            return node;
        }
        /// <summary>
        /// This method removes an item from the top of the stack
        /// </summary>
        /// <returns>Returns the new top of the stack</returns>
        public Node<T> Pop()
        {
            Node<T> node = Top;
            Top = Top.Next;
            node.Next = null;
            return node;
        }
        /// <summary>
        /// This method checks the value of the top node of the stack.
        /// </summary>
        /// <returns>Returns the value of the top node.</returns>
        public T Peek()
        {
            return Top.Value;
        }
    }
}
