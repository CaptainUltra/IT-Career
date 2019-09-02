using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();
            for(int i = 0; i<nums.Count;i++)
            {
                if(Math.Sqrt(nums[i])== (int) Math.Sqrt(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }
            //Sort with Linq
            //var ascendingOrder = li.OrderBy(i => i);
            //var descendingOrder = li.OrderByDescending(i => i);
            //Without Linq; With Lambda
            //li.Sort((a, b) => a.CompareTo(b)); // ascending sort
            result.Sort((a, b) => -1* a.CompareTo(b)); // descending sort
            System.Console.WriteLine(String.Join(' ', result));
        }
    }
}
