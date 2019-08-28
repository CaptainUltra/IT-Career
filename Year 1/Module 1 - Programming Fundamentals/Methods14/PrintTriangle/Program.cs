using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for(int i = start; i<=end; i++)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            //Print gorna chast
            for(int i = 1; i<=n;i++)
            {
                PrintLine(1, i);
            }
            //Print dolna chast
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
