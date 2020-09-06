using System;
using System.Collections.Generic;
using System.Linq;

namespace HanoiTowers
{
    class Program
    {
        private static int stepsTaken = 0;
        private static Stack<int> source;
        private static Stack<int> destination = new Stack<int>();
        private static Stack<int> spare = new Stack<int>();

        /// <summary>
        /// Recursive function which moves discs between rods in order to transfer them from source to destination.
        /// </summary>
        /// <param name="bottomDisk"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="spare"></param>
        private static void MoveDiscs(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                destination.Push(source.Pop());
                stepsTaken++;
                System.Console.WriteLine($"Step {stepsTaken}: Moved disc {bottomDisk}");
                PrintRods();
            }
            else
            {
                MoveDiscs(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());
                System.Console.WriteLine($"Step {stepsTaken}: Moved disc {bottomDisk}");
                PrintRods();
                MoveDiscs(bottomDisk - 1, spare, destination, source);
            }
        }

        /// <summary>
        /// Prints the current state of the rods.
        /// </summary>
        private static void PrintRods()
        {
            System.Console.WriteLine("Source: {0}", String.Join(", ", source.Reverse()));
            System.Console.WriteLine("Destination: {0}", String.Join(", ", destination.Reverse()));
            System.Console.WriteLine("Spare: {0}", String.Join(", ", spare.Reverse()));
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int numberOfDiscs = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, numberOfDiscs).Reverse());
            PrintRods();
            MoveDiscs(numberOfDiscs, source, destination, spare);
        }
    }
}
