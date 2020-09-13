using System;

namespace BinaryTree
{
    class BinaryTree<T> where T : IComparable
    {
        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Item { get; set; }
        }

        private Node Root { get; set; }
        public int Count { get; private set; }
        public void Add(T item)
        {
            Node node = new Node();
            node.Item = item;

            if (Root == null)
            {
                Root = node;
                return;
            }

            Node iterator = Root;
            while (true)
            {
                if (iterator.Left != null && iterator.Item.CompareTo(item) >= 0)
                    iterator = iterator.Left;
                else if (iterator.Right != null && iterator.Item.CompareTo(item) < 0)
                    iterator = iterator.Right;
                else
                    break;
            }

            if (iterator.Item.CompareTo(item) >= 0)
                iterator.Left = node;
            else if (iterator.Item.CompareTo(item) < 0)
                iterator.Right = node;
        }

        //TODO: Implement the function.
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }
        public bool Contains(T item)
        {
            if (this.Root == null)
                return false;

            var iterator = this.Root;
            while (true)
            {
                if (iterator == null)
                    return false;
                if (iterator.Item.CompareTo(item) == 0)
                    return true;
                if (iterator.Item.CompareTo(item) > 0)
                    iterator = iterator.Left;
                else iterator = iterator.Right;
            }
        }

        public void PrintIndentedPreOrder(int indent = 0)
        {
            PrintIndentedPreOrder(this.Root, 0);
        }
        private void PrintIndentedPreOrder(Node node, int indent)
        {
            //Print node
            if (node == null)
                return;
            Console.WriteLine(new string(' ', indent * 2) + node.Item);
            //Left
            PrintIndentedPreOrder(node.Left, indent + 1);
            //Right
            PrintIndentedPreOrder(node.Right, indent + 1);
        }
    }
}