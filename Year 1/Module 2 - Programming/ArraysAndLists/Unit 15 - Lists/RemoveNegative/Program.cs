using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int i = 0 ;i<nums.Count;i++)
            {
                if(nums[i]<0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
            nums.Reverse();
            if(nums.Count>0)System.Console.WriteLine(String.Join(" ", nums));
            else System.Console.WriteLine("Empty");
        }
    }
}
