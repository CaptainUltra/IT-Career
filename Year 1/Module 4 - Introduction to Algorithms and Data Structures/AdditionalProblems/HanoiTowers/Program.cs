using System;
using System.Collections.Generic;
using System.Linq;

namespace HanoiTowers
{
    class Program
    {
        private static int stepsTaken = 0;
        private static Stack<int> source;
        private static readonly Stack<int> destination = new Stack<int>();
        private static readonly Stack<int> spare = new Stack<int>();
        private static void MoveDiscs(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if(bottomDisk == 1)
            {
                destination.Push(source.Pop());
                stepsTaken++;
                System.Console.WriteLine($"Step #{stepsTaken}: Moved disc {bottomDisk}");
                PrintRods();
            }
            else
            {
                MoveDiscs(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());
                System.Console.WriteLine($"Step #{stepsTaken}: Moved disc {bottomDisk}");
                PrintRods();
                MoveDiscs(bottomDisk - 1, spare, destination, source);
            }
        }
        private static void PrintRods()
        {
            System.Console.WriteLine("Source: {0}", String.Join(", ", source.Reverse()));
            System.Console.WriteLine("Destination: {0}", String.Join(", ", destination.Reverse()));
            System.Console.WriteLine("Spare: {0}", String.Join(", ", spare.Reverse()));
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int numberOfDiscs = 3;
            source = new Stack<int>(Enumerable.Range(1, numberOfDiscs).Reverse());
            PrintRods();
            MoveDiscs(numberOfDiscs, source, destination, spare);
        }
    }
}
