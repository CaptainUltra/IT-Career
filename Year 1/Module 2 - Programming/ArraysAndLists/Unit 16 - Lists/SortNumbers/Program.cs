using System;
using System.Linq;
using System.Collections.Generic;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
