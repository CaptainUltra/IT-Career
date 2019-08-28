using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            switch(type)
            {
                case "premiere": Console.WriteLine("{0:f2}" + "leva", r*c*12.00); break;
                case "normal": Console.WriteLine("{0:f2}" + "leva", r * c * 7.50); break;
                case "discount": Console.WriteLine("{0:f2}" + "leva", r * c * 5.00); break;
            }
        }
    }
}
