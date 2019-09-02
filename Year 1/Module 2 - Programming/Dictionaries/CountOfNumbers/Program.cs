using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var result = new Dictionary<double, int>();
            foreach(var num in nums)
            {
                if(!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }
            
        }
    }
}
