using System;
using System.Linq;
using System.Collections.Generic;

namespace Presentation14
{
    class Program
    {
        static void Main(string[] args)
        {
            //------min and max
            /* List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = nums.Max();
            int min = nums.Min();
            List<int> result = new List<int>();
            for(int i=0;i<nums.Count;i++)
            {
                if(nums[i]==min||nums[i]==max) result.Add(nums[i]);
            }
            result.Sort();
            System.Console.WriteLine(String.Join(' ', result)); */
            //--------Longest sequence
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int start = nums[0];
            int bestLenght = 1;
            int lenght = 1;
            int bestStart = nums[0];
            for(int i = 1; i<nums.Count;i++)
            {
                if(nums[i] == start) lenght++;
                else 
                {
                    if(lenght>bestLenght)
                    {
                    bestLenght = lenght;
                    bestStart = start;
                    }
                    start = nums[i];
                    lenght = 1;
                }
            }
            if(lenght>bestLenght)
            {
                bestLenght = lenght;
                bestStart = start;
            }
            for(int i = 0; i < bestLenght; i++) result.Add(bestStart);
            System.Console.WriteLine(String.Join(' ', result));
        }
    }
}
