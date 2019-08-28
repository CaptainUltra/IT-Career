using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, m;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            m = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((a * b) / m));
        }
    }
}
