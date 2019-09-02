using System;
using System.Collections.Generic;
using System.Linq;

namespace Subset_03_3_Prez
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            System.Console.WriteLine(String.Join(", ", MaxSubSequence(a)));
        }
        public static List<int> MaxSubSequence(List<int> list)
        {
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            int i = 1;
            do
            {
                tempSubSequence.Add(list[i-1]);
                while((i < list.Count()) && (list[i-1] < list[i]))
                tempSubSequence.Add(list[i++]);
                if(maxSubSequence.Count() < tempSubSequence.Count())
                {
                    maxSubSequence.Clear();
                    maxSubSequence.AddRange(tempSubSequence);
                }
                tempSubSequence.Clear();
                i++;
            }while(i<list.Count());
            return maxSubSequence;
        }
    }
}
