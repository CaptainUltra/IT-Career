using System;
using System.Linq;
using System.Collections.Generic;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b = new int[a.Length +1];
            Array.Copy(a,b, a.Length);
            var elt = int.Parse(Console.ReadLine());
            int i = b.Length - 1;
            while((i > 0) && (elt<b[i-1]))
            {
                b[i]=b[i-1];
                i--;
            }
            b[i] = elt;
            System.Console.WriteLine(String.Join(' ', a));
            System.Console.WriteLine(String.Join(' ', b));
        }
    }
}
