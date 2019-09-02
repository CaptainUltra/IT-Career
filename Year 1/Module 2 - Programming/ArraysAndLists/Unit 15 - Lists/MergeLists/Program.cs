using System;
using System.Linq;
using System.Collections.Generic;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();
            for(int i = items.Count-1;i>=0;i--)
            {
                List<int> nums = items[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                foreach(var it in nums)
                {
                    result.Add(it);
                }
            }
            System.Console.WriteLine(String.Join("", result));
            
        }
    }
}
