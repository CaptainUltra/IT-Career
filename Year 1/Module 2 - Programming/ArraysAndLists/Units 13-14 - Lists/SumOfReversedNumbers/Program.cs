using System;
using System.Linq;
using System.Collections.Generic;

namespace SumOfReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            for(int i = 0;i<nums.Count; i++)
            {
                List<char> cif = nums[i].ToList();
                cif.Reverse();
                sum += int.Parse((String.Join("", cif)));
            }
            System.Console.WriteLine(sum);
        }
    }
}
