using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var m1 = Console.ReadLine();
            var m2 = Console.ReadLine();
            double a = 0;//suma v metri
            switch (m1)
            {
                case "m": a = n; break;
                case "mm": a = n / 1000; break;
                case "cm": a = n / 100; break;
                case "mi": a = n / 0.000621371192; break;
                case "in": a = n / 39.3700787; break;
                case "km": a = n * 1000; break;// ili /0.0001
                case "ft": a = n / 3.2808399; break;
                case "yd": a = n / 1.0936133; break;
            }
            switch(m2)
            {
                case "m": Console.WriteLine(a + " m"); break;
                case "mm": Console.WriteLine(a * 1000 + " mm"); break;
                case "cm": Console.WriteLine(a * 100 + " cm"); break;
                case "mi": Console.WriteLine(a * 0.000621371192 + " mi"); break;
                case "in": Console.WriteLine(a * 39.3700787 + " in"); break;
                case "km": Console.WriteLine(a / 1000 + " km"); break;
                case "ft": Console.WriteLine(a * 3.2808399 + " ft"); break;
                case "yd": Console.WriteLine(a * 1.0936133 + " yd"); break;
            }

        }
    }
}
