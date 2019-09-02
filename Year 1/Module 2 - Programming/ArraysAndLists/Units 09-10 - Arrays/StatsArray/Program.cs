using System;
using System.Linq;

namespace StatsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Min = "+ items.Min());
            Console.WriteLine("Max = "+ items.Max());
            Console.WriteLine("Sum = "+ items.Sum());
            Console.WriteLine("Average = "+ items.Average());
        }
    }
}
