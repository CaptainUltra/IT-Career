using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Exam5_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var dollar = double.Parse(Console.ReadLine());
            var month = m * n;
            var year = month * 12 + month * 2.5;
            year = year * 0.75;
            var leva = year * dollar;
            Console.WriteLine("{0:f2}",leva/365);
        }
    }
}
