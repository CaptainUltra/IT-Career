using System;
using System.Linq;
using System.Collections.Generic;

namespace CountOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
            {
                int num = nums[pos], count = 1;
                while (pos + count < nums.Count && nums[pos + count] == num)
                    count++;
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
