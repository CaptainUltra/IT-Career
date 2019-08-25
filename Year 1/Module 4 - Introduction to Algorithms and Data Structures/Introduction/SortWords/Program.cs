using System;
using System.Collections.Generic;
using System.Linq;

namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(' ').ToList();
            for (int j = 0; j < a.Count - 1; j++)
            {
                string min = a[j];
                int minPos = j;
                for (int i = j + 1; i < a.Count; i++)
                {
                    if (String.Compare(a[i], min) < 0)
                    {
                        min = a[i];
                        minPos = i;
                    }
                }
                a[minPos] = a[0];
                a[0] = min;
            }
            System.Console.WriteLine(String.Join(' ', a));
        }
    }
}
