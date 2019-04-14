using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Current { get; set; }
        List<T> list = new List<T>();
       /// <summary>
       /// preorder recursive traversal of a tree
       /// </summary>
       /// <param name="Root">root of the tree</param>
       /// <param name="list">list to contain traversed values</param>
       /// <returns>list of traversed node values</returns>
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
        /// <summary>
        /// In order recursive traversal of a tree
        /// </summary>
        /// <param name="Root">root of the tree</param>
        /// <param name="list">list to hold traversed values</param>
        /// <returns>list of traversed node values</returns>
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
        /// <summary>
        /// postorder recursive traversal of a tree
        /// </summary>
        /// <param name="Root">root node of the tree</param>
        /// <param name="list">list to hold traversed values</param>
        /// <returns>list of traversed node values</returns>
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
