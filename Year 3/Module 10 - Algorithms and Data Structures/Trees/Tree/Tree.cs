using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree
{
    public class Tree<T>
    {
        public T Value { get; private set; }
        public List<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>(children);
        }
        public void Print(int indent = 0)
        {
            this.Print(this, indent);
        }

        private void Print(Tree<T> tree, int indent)
        {
            Console.WriteLine(new string(' ', indent*2) + tree.Value);
            foreach(Tree<T> child in tree.Children)
            {
                child.Print(indent+1);
            }

        }
        public IEnumerable<T> OrderDFSIterative()
        {
            List<T> result = new List<T>();
            Stack<Tree<T>> stack = new Stack<Tree<T>>();

            stack.Push(this); 

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                foreach (Tree<T> child in current.Children)
                {
                    stack.Push(child);
                }
                result.Add(current.Value);
            }

            return result;
        }
        public IEnumerable<T> OrderDFS()
        {
            List<T> result = new List<T>();
            this.DFS(this, result);

            return result;
        }

        private void DFS(Tree<T> node, List<T> result)
        {
            foreach (Tree<T> child in node.Children)
            {
                child.DFS(child, result);
            }
            result.Add(node.Value);
        }


        //BFS
        public IEnumerable<T> OrderBFS()
        {
            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            List<T> result  = new List<T>();

            queue.Enqueue(this);
            while(queue.Count > 0)
            {
                Tree<T> current = queue.Dequeue();
                result.Add(current.Value);
                foreach(var child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return result;
        }
    }
}