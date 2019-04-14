using System;
using System.Collections.Generic;
using Tree.Classes;
using Xunit;

namespace TreeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTree()
        {
            BinaryTree<int> bT = new BinaryTree<int>();

            Assert.Null(bT.Root);
        }
        [Fact]
        public void SingleNodeTree()
        {
            BinaryTree<int> bT = new BinaryTree<int>();
            Node<int> node1 = new Node<int>()
            {
                Value = 1
            };
            bT.Root = node1;

            Assert.Equal(1, bT.Root.Value);
        }
        [Fact]
        public void CanAddChildren()
        {
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
            bT.Root = node1;
            bT.Root.LeftChild = node2;
            bT.Root.RightChild = node3;
            Assert.NotNull(bT.Root.LeftChild);
            Assert.NotNull(bT.Root.RightChild);
        }
        [Fact]
        public void PreorderReturn()
        {
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
            bT.PreOrder(bT.Root, pre);
            List<int> test = new List<int>() { 1, 2, 4, 5, 3, 6, 7 };

            Assert.Equal(test, pre);
        }
        [Fact]
        public void InorderReturn()
        {
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

            List<int> inorder = new List<int>();
            bT.InOrder(bT.Root, inorder);
            List<int> test = new List<int>() { 4, 2, 5, 1, 6, 3, 7 };

            Assert.Equal(test, inorder);
        }
        [Fact]
        public void PostOrderReturn()
        {
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

            List<int> post = new List<int>();
            bT.PostOrder(bT.Root, post);
            List<int> test = new List<int>() { 4, 5, 2, 6, 7, 3, 1 };

            Assert.Equal(test, post);
        }
    }
}
