using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node<int> Root {get; set;}
        public Node<int> Current { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }
        /// <summary>
        /// Adds new nodes to the Binary search tree, begins at the root and checks to see where to put node based on value greater or less than root. 
        /// </summary>
        /// <param name="value">value of the data in the new node</param>
        /// <param name="root">root of the tree</param>
        public void Add(int value, Node<int> root)
        {
            Node<int> node = new Node<int>
            {
                Value = value
            };
            if (Root == null)
            {
                Root = node;
                return;
            }
            if (node.Value < root.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = node;
                }
                else
                {
                    Add(value, root.LeftChild);
                }
            }
            if (node.Value >= root.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = node;
                }
                else
                {
                    Add(value, root.RightChild);
                }
            }
        }
        /// <summary>
        /// Checks to see if the BST contains a certain value
        /// </summary>
        /// <param name="value">value to search</param>
        /// <param name="root">root of the tree</param>
        /// <returns>boolean, true if found</returns>
        public bool Contains(int value, Node<int> root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value == value)
            {
                return true;
            }
            if (value >= root.Value)
            {
                if (Contains(value, root.RightChild))
                {
                    return true;
                }
            }
            if (value < root.Value)
            {
                if (Contains(value, root.LeftChild))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
