using System.Collections.Generic;
using System.Linq;

namespace TreeExercise
{
    public class Tree<T>
    {
        public T Value {get; private set;}
        public Tree<T> Parent {get; private set;}
        public List<Tree<T>> Children {get; private set;}

        //Calculation fields
        public static Tree<T> DeepestNode {get; private set;}
        private static int MaxDepth = 0;
        public static List<Tree<T>> LongestRoute;
        private static List<Tree<T>> CurrentRoute;

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>(children);
        }
        public void AddChild(Tree<T> child)
        {
            this.Children.Add(child);
        }
        public void AddParent(Tree<T> parent)
        {
            this.Parent = parent;
        }
        public static void PrintTree(Tree<T> node, int indent = 0)
        {
            System.Console.WriteLine(new string(' ', indent * 2) + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent+1);
            }
        }

        public static void CalculateDeepestNode(Tree<T> node, int currentDepth = 0)
        {
            if(currentDepth > MaxDepth)
            {
                MaxDepth = currentDepth;
                DeepestNode = node;
            }
            foreach (var child in node.Children)
            {
                CalculateDeepestNode(child, currentDepth + 1);
            }
        }
        public static void CalculateLongestRoute(Tree<T> node)
        {
            CurrentRoute = new List<Tree<T>>();
            LongestRoute = new List<Tree<T>>();

            CurrentRoute.Add(node);
            LongestRoute.Add(node);
            CalculateLongestRoutePrivate(node);
        }
        private static void CalculateLongestRoutePrivate(Tree<T> node)
        {
            if(CurrentRoute.Count > LongestRoute.Count)
            {
                LongestRoute = CurrentRoute.ToList();
            }
            foreach(var child in node.Children)
            {
                CurrentRoute.Add(child);
                CalculateLongestRoutePrivate(child);
                CurrentRoute.Remove(child);
            }
        }
    }
}