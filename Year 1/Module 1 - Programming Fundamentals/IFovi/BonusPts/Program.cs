using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPts
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b=0;
            if (a <= 100) b += 5;
            if (a > 100 && a < 1000) b +=  0.2*a;
            if (a > 1000) b += a * 0.1;
            if (a % 2 == 0) b++;
            if ((a % 10) == 5) b += 2;
            Console.WriteLine(b);
            Console.WriteLine(a+b);
        }
    }
}
