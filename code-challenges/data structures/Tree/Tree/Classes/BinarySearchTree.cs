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

        public void Add(int value, Node<int> root)
        {
            Node<int> node = new Node<int>
            {
                Value = value
            };
            if (root == null)
            {
                node = root;
                return;
            }
            if (node.Value < root.Value)
            {
                if (root.LeftChild == null)
                {
                    node = root.LeftChild;
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
                    node = root.RightChild;
                }
                else
                {
                    Add(value, root.RightChild);
                }
            }
        }
        public bool Contains(int value, Node<int> root)
        {
            if (root.Value == value)
            {
                return true;
            }
            if (root.Value < value)
            {
                Contains(value, root.LeftChild);
            }
            if (root.Value >= value)
            {
                Contains(value, root.RightChild);
            }
            return false;
        }
    }
}
