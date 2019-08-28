using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFillRectangle
{
    class Program
    {
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n));
        }
        static void PrintMid(int n)
        {
            Console.Write('-');
            for(int i=0;i<=n-2;i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for(int i = 0;i < -2;i++)
            {
                PrintMid(n);
            }
            PrintHeader(n);
        }
    }
}
