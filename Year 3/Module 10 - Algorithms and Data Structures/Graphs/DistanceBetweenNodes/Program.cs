using System;
using System.Linq;
using System.Collections.Generic;

namespace DistanceBetweenNodes
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static Dictionary<int, bool> visited;
        static int minCount;

        static void Main(string[] args)
        {
            graph = new Dictionary<int, List<int>>();
            int nodeCount = int.Parse(Console.ReadLine());
            int pathsToFindCount = int.Parse(Console.ReadLine());

            //Nodes input
            for (int i = 0; i < nodeCount; i++)
            {

                var input = Console.ReadLine().Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int node = input[0];
                var connections = input.Skip(1).ToList();

                graph[node] = new List<int>();
                graph[node].AddRange(connections);
            }

            //Paths to try inptut
            for (int i = 0; i < pathsToFindCount; i++)
            {
                var nodes = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                visited = new Dictionary<int, bool>();
                foreach (var node in graph.Keys)
                {
                    visited.Add(node, false);
                }
                minCount = graph.Count();

                Path(nodes[0], 0, nodes[1]);
                if (minCount == graph.Count) minCount = -1;
                System.Console.WriteLine("{" + nodes[0] + ", " + nodes[1] + "} -> " + minCount);
            }
        }
        static void Path(int current, int counter, int destination)
        {
            visited[current] = true;
            if (current == destination)
            {
                if (counter < minCount)
                {
                    minCount = counter;
                    visited[current] = false;
                    return;
                }
            }            
            foreach (var child in graph[current])
            {
                if (!visited[child])
                {
                    Path(child, counter + 1, destination);
                }
            }
            visited[current] = false;
        }
    }
}
