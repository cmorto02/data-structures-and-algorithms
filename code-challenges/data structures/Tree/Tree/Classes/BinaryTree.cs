using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Current { get; set; }
       
        public List<T> PreOrder(Node<T> Root, List<T> list)
        {
            list.Add(Root.Value);
            if (Root.LeftChild != null)
            {
                PreOrder(Root.LeftChild, list);
            }
            if (Root.RightChild != null)
            {
                PreOrder(Root.RightChild, list);
            }
            return list;
        }
        public List<T> InOrder(Node<T> Root, List<T> list)
        {
            if (Root.LeftChild != null)
            {
                InOrder(Root.LeftChild, list);
            }
            list.Add(Root.Value);
            if (Root.RightChild != null)
            {
                InOrder(Root.RightChild, list);
            }
            return list;
        }
        public List<T> PostOrder(Node<T> Root, List<T> list)
        {
            if (Root.LeftChild != null)
            {
                PostOrder(Root.LeftChild, list);
            }
            if (Root.RightChild != null)
            {
                PostOrder(Root.RightChild, list);
            }
            list.Add(Root.Value);
            return list;
        }
    }
}
