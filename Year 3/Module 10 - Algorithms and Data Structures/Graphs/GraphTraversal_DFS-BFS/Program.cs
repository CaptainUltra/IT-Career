using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphTraversal_DFS_BFS
{
    //Different way of representing a graph with class Node
    /*class Node
    {
        public int Id { get; set; }
        public List<int> Children { get; set; }
    }*/
    class Program
    { 
        static List<int>[] graph;
        static bool[] visited;

        static void Dfs(int n)
        {
            if (!visited[n])
            {
                visited[n] = true;
                foreach (var child in graph[n])
                { 
                    Dfs(child);
                }
                Console.Write($"{n} ");
            }
        }
        static void Bfs(int n)
        {
            if (visited[n])
            {
                return;
            }
            var queue = new Queue<int>();
            queue.Enqueue(n);
            visited[n] = true;

            while (queue.Count !=0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);

                foreach (var child in graph[current])
                {
                    if (!visited[child])
                    {
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }
        }
        

        static void Main(string[] args)
        {
            //Different way of representing a graph with class Node
            //graph = new List<Node>;

            graph = new List<int>[]
            {
                new List<int> {3, 6},
                new List<int> {2, 3, 4, 5, 6},
                new List<int> {1, 4, 5},
                new List<int> {0, 1, 4},
                new List<int> {1, 2, 6},
                new List<int> {1, 2, 3},
                new List<int> {0, 1, 4},
                new List<int> {8},
                new List<int> {7}
            };

            visited = new bool[graph.Length];
            for (int i = 0; i < graph.Length; i++)
            {
                //Dfs(i);
                Bfs(i);
            }

            //Connected components
            /*var components = 0;
            for (int i = 0; i < graph.Length; i++)
            {
                if(!visited[i])
                {
                    components++;
                    Console.WriteLine($"Connected component {components}: ");
                    Dfs(i);
                    Console.WriteLine();
                }
            }*/
        }
    }
}
