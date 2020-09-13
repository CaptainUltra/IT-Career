using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeExercise
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input: ");
            ReadTree();
            System.Console.WriteLine("Tree: ");
            Print();
            System.Console.WriteLine("Leaves: ");
            PrintLeaves();
            System.Console.WriteLine("Middle nodes: ");
            PrintMiddleNodes();
            
            var rootNode = GetRootNode();
            PrintDeepestNode(rootNode);
            PrintLongestRoute(rootNode);
        }
        static Tree<int> GetTreeNodeByValue(int value)
        {
            if(!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }

            return nodeByValue[value];
        }

        static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);

            parentNode.AddChild(childNode);
            childNode.AddParent(parentNode);
        }

        static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }
        
        static Tree<int> GetRootNode()
        {
            return nodeByValue.Values
                .FirstOrDefault(x => x.Parent == null);
        }

        static void Print()
        {
            var root = GetRootNode();
            Tree<int>.PrintTree(root);
        }

        static void PrintLeaves()
        {
            var nodes = nodeByValue.Values.Where(x => x.Children.Count == 0).OrderBy(x => x.Value).Select(x => x.Value);
            System.Console.WriteLine(string.Join(", ", nodes));
        }
        static void PrintMiddleNodes()
        {
            var nodes = nodeByValue.Values.Where(x => x.Children.Count != 0 && x.Parent != null).OrderBy(x => x.Value).Select(x => x.Value);
            System.Console.WriteLine(string.Join(", ", nodes));
        }
        static void PrintDeepestNode(Tree<int> root)
        {
            Tree<int>.CalculateDeepestNode(root);
            var deepest = Tree<int>.DeepestNode;
            System.Console.WriteLine($"Deepest node: {deepest.Value}");
        }
        static void PrintLongestRoute(Tree<int> root)
        {
            Tree<int>.CalculateLongestRoute(root);
            System.Console.WriteLine("Longest path: ");
            System.Console.WriteLine(string.Join(", ", Tree<int>.LongestRoute.Select(x => x.Value)));
        }
    }
}
