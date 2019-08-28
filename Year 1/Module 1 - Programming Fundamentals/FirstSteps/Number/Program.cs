using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, e1, e2, e3, e4;
            k = int.Parse(Console.ReadLine());
            e1 = k % 10;
            e2 = k / 10 % 10;
            e3 = k / 100 % 10;
            e4 = k / 1000;
            Console.WriteLine((e1 + e2 * 10 + e4 * 100) + (e1 + e3 * 10 + e4 * 100));
        }
    }
}
