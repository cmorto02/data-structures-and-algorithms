using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Current { get; set; }
        Queue<T> queue = new Queue<T>();
       
        public void PreOrder(Node<T> Root, Queue<T> queue)
        {
            queue.Enqueue(Root.Value);
            if (Root.LeftChild != null)
            {
                PreOrder(Root.LeftChild, queue);
            }
            if (Root.RightChild != null)
            {
                PreOrder(Root.RightChild, queue);
            }
        }
        public void InOrder(Node<T> Root, Queue<T> queue)
        {
            if (Root.LeftChild != null)
            {
                InOrder(Root.LeftChild, queue);
            }
            queue.Enqueue(Root.Value);
            if (Root.RightChild != null)
            {
                InOrder(Root.RightChild, queue);
            }
        }
        public void PostOrder(Node<T> Root, Queue<T> queue)
        {
            if (Root.LeftChild != null)
            {
                PostOrder(Root.LeftChild, queue);
            }
            if (Root.RightChild != null)
            {
                PostOrder(Root.RightChild, queue);
            }
            queue.Enqueue(Root.Value);

        }
    }
}
