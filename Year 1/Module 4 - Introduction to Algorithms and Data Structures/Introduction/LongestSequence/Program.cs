using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = 0;
            int valueMax = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                int br = 0;
                int value = a[i];
                while (i < a.Count - 1 && a[i + 1] == a[i])
                {
                    br++;
                    i++;
                }
                if (br > max)
                {
                    max = br;
                    valueMax = value;
                }
            }
            for (int i = 0; i < max; i++)
            {
                result.Add(valueMax);
            }
            System.Console.WriteLine(String.Join(' ', result));
        }
    }
}
