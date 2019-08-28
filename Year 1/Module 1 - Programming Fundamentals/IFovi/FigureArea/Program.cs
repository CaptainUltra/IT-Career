using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch(type)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    double area = a * a;
                    Console.WriteLine(Math.Round(area,3));
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI*r*r;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = (a*b)/2;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
            }
        }
    }
}
