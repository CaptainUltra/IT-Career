using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.Add(19);
            tree.Add(25);
            tree.Add(9);
            tree.Add(6);
            tree.Add(11);
            tree.Add(22);
            tree.Add(31);
            tree.Add(8);
            tree.Add(18);
            tree.Add(21);

            tree.PrintIndentedPreOrder();
            System.Console.WriteLine(tree.Contains(21));
        }
    }
}
