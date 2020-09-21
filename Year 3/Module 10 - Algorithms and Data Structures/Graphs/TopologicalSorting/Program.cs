using System;
using System.Collections.Generic;
using System.Linq;

namespace TopologicalSorting
{
    class Program
    {
        static List<int>[] graph;
        static HashSet<int> GetNodesWithIncomingEdges()
        {
            var nodeWithIncomingEdges = new HashSet<int>();
            graph.SelectMany(s => s)
                .ToList()
                .ForEach(e => nodeWithIncomingEdges.Add(e));
            return nodeWithIncomingEdges;
        }
        static void Main(string[] args)
        {
            graph = new List<int>[]
            {
                new List<int> {1,2},    //A: B, C
                new List<int> {3,4},    //B: D, E
                new List<int> {5},      //C: F  
                new List<int> {2,5},    //D: C, F
                new List<int> {3},      //E: D
                new List<int> { },      //F: 
            };

            var result = new List<int>();
            var nodes = new HashSet<int>();

            var nodesWithIncomingEdges = GetNodesWithIncomingEdges();
            for (int i = 0; i < graph.Length; i++)
            {
                if (!nodesWithIncomingEdges.Contains(i))
                {
                    nodes.Add(i);
                }
            }
            while (nodes.Count !=0)
            {
                var currentNode = nodes.First();
                nodes.Remove(currentNode);

                result.Add(currentNode);
                var children = graph[currentNode].ToList();
                graph[currentNode] = new List<int>();

                var leftNodesWithIncomingEdges = GetNodesWithIncomingEdges();
                
                foreach (var child in children)
                {
                    if (!leftNodesWithIncomingEdges.Contains(child))
                    {
                        nodes.Add(child);
                    }    
                }
            }
            if(graph.SelectMany(s=>s).Any())
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
