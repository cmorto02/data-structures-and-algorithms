using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            

            tree.Add(34, tree.Root);
            tree.Add(3, tree.Root);
            tree.Add(32, tree.Root);
            tree.Add(14, tree.Root);
            tree.Add(27, tree.Root);
            tree.Add(67, tree.Root);
            tree.Add(234, tree.Root);

            Console.WriteLine("Binary Search Tree Add: 34, 3, 67");
            Console.WriteLine();
            Console.WriteLine("Root.Value:");
            Console.WriteLine(tree.Root.Value);
            Console.WriteLine("RightChild.Value");
            Console.WriteLine(tree.Root.RightChild.Value);
            Console.WriteLine("LeftChild.Value:");
            Console.WriteLine(tree.Root.LeftChild.Value);


            Console.WriteLine("Contins: 3");
            bool truth = tree.Contains(3, tree.Root);
            Console.WriteLine(truth);

            Console.WriteLine("Binary Tree: PreOrder");
            BinaryTree<int> bT = new BinaryTree<int>();
            Node<int> node1 = new Node<int>()
            {
                Value = 1
            };
            Node<int> node2 = new Node<int>()
            {
                Value = 2
            };
            Node<int> node3 = new Node<int>()
            {
                Value = 3
            };
            Node<int> node4 = new Node<int>()
            {
                Value = 4
            };
            Node<int> node5 = new Node<int>()
            {
                Value = 5
            };
            Node<int> node6 = new Node<int>()
            {
                Value = 6
            };
            Node<int> node7 = new Node<int>()
            {
                Value = 7
            };
            bT.Root = node1;
            bT.Root.LeftChild = node2;
            bT.Root.RightChild = node3;
            bT.Root.LeftChild.LeftChild = node4;
            bT.Root.LeftChild.RightChild = node5;
            bT.Root.RightChild.LeftChild = node6;
            bT.Root.RightChild.RightChild = node7;

            List<int> pre = new List<int>();
            List<int> inorder = new List<int>();
            List<int> post = new List<int>();

            bT.PreOrder(bT.Root, pre);
            bT.InOrder(bT.Root, inorder);
            bT.PostOrder(bT.Root, post);


            pre.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            Console.WriteLine("Binary Tree: InOrder");
            inorder.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            Console.WriteLine("Binary Tree: PostOrder");
            post.ForEach(i => Console.Write("{0} ", i));
        }
    }
}
