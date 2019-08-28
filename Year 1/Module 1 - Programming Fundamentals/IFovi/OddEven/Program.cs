using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = int.Parse(Console.ReadLine());
            if (e % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
