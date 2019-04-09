using System;
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

            Console.WriteLine(tree.Root.Value);

            //bool truth = tree.Contains(27, tree.Root);
            //Console.WriteLine(truth);
        }
    }
}
