using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var ch = char.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) Console.Write("*");
            Console.WriteLine();
            for (int i = 1; i <= n - 2; i++)//redove
            {
                Console.Write("*");
                for (int j = 1; j <= n - 2; j++) Console.Write("*");
                Console.WriteLine("*");
            }
            for (int i = 1; i <= n; i++) Console.Write("*");
        }
    }
}
