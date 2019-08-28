using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_Exam1_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double br1 = 0, br2 = 0, br3 = 0;
            for (int i = 0; i < n; i++)
            {
                var a = double.Parse(Console.ReadLine());
                if (a % 2 == 0) br1++;
                if (a % 3 == 0) br2++;
                if (a % 4 == 0) br3++;
            }
            double p1 = br1 / n * 100;
            double p2 = br2 / n * 100;
            double p3 = br3 / n * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}

