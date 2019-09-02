using System;
using System.Linq;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var b = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            int ia = 0;
            int ib = 0;
            while(ia < a.Count() && ib<b.Count())
            {
                if(a[ia] < b[ib])
                {
                    result.Add(a[ia]);
                    ia++;
                }
                else
                {
                    result.Add(b[ib]);
                    ib++;
                }
            }
            if(ia == a.Count)
            {
                while(ia < a.Count())
                {
                    result.Add(a[ia]);
                }
            }
            if(ib == b.Count)
            {
                while(ib < b.Count())
                {
                    result.Add(b[ib]);
                }
            }
            System.Console.WriteLine(String.Join(", ", result));
        }
    }
}
