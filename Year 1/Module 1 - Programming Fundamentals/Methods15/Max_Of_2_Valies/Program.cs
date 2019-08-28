using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Of_2_Valies
{
    class Program
    {
        static void GetMax(double a, double b)
        {
            Console.WriteLine(Math.Max(a, b));
        }
        static void GetMax(char a, char b)
        {
            if (a > b) Console.WriteLine(a);
            if (b > a) Console.WriteLine(b);
        }
        static void GetMax(string a, string b)
        {
            if (string.Compare(a, b) > 0) Console.WriteLine(a);
            if (string.Compare(a, b) < 0) Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            else if (type == "char")
            {
                var a = char.Parse(Console.ReadLine());
                var b = char.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            else
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();
                GetMax(a, b);
            }
        }
    }
}
