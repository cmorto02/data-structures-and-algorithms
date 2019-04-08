using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree<T>
    {
        public Node<int> Root {get; set;}

        public void Add(int value)
        {
            Node<int> node = new Node<int>
            {
                Value = value
            };
            if (Root == null)
            {
                node = Root;
            }
            if (node.Value < Root.Value)
            {
                node = Root.LeftChild;
            }
            if (node.Value > Root.Value)
            {
                node = Root.RightChild;
            }
        }
    }
}
