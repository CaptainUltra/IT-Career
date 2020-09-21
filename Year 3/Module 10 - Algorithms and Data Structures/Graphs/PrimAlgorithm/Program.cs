using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimAlgorithm
{
    class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static HashSet<int> spannigTree = new HashSet<int>();
        static Dictionary<int, List<Edge>> nodeToEdges = new Dictionary<int, List<Edge>>();

        static void Main(string[] args)
        {
            var graph = new List<Edge>()
            {
                new Edge {First = 2, Second = 4, Weight = 2},
                new Edge {First = 1, Second = 2, Weight = 4},
                new Edge {First = 1, Second = 3, Weight = 5},
                new Edge {First = 8, Second = 9, Weight = 7},
                new Edge {First = 1, Second = 4, Weight = 9},
                new Edge {First = 4, Second = 5, Weight = 8},
                new Edge {First = 5, Second = 6, Weight = 12},
                new Edge {First = 7, Second = 8, Weight = 8},
                new Edge {First = 7, Second = 9, Weight = 10},
                new Edge {First = 3, Second = 5, Weight = 7},
                new Edge {First = 3, Second = 4, Weight = 20},
            };

            var nodes = graph.Select(e => e.First)
                    .Union(graph.Select(e => e.Second))
                    .Distinct()
                    .OrderBy(e => e)
                    .ToHashSet();

            foreach (var edge in graph)
            {
                if(!nodeToEdges.ContainsKey(edge.First))
                {
                    nodeToEdges[edge.First] = new List<Edge>();
                }
                if (!nodeToEdges.ContainsKey(edge.Second))
                {
                    nodeToEdges[edge.Second] = new List<Edge>();
                }
                nodeToEdges[edge.First].Add(edge);
                nodeToEdges[edge.Second].Add(edge);
            }
            foreach (var node in nodes)
            {
                if(!spannigTree.Contains(node))
                {
                    Prim(node);
                }
            }
        }
        static void Prim(int startingNode)
        {
            spannigTree.Add(startingNode);

            var items = new List<Edge>();

            items.AddRange(nodeToEdges[startingNode]);
            items = items.OrderBy(x => x.Weight).ToList();

            while (items.Count !=0)
            {
                var minEdge = items.First();
                items.Remove(minEdge);

                var first = minEdge.First;
                var second = minEdge.Second;
                var nonTreeNode = -1;

                if(spannigTree.Contains(first) && !spannigTree.Contains(second))
                {
                    nonTreeNode = second;
                }
                if(spannigTree.Contains(second) && !spannigTree.Contains(first))
                {
                    nonTreeNode = first;
                }
                if(nonTreeNode == -1)
                {
                    continue;
                }
                spannigTree.Add(nonTreeNode);
                Console.WriteLine($"{minEdge.First} - {minEdge.Second}");
                items.AddRange(nodeToEdges[nonTreeNode]);
                items = items.OrderBy(x => x.Weight).ToList();
            }
        }
    }
}
