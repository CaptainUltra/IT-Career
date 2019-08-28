using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Exam4_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //top
            Console.Write(new string('.', n));
            Console.Write(new string('*', 3 * n));
            Console.WriteLine(new string('.', n));
            //top mid
            for (int i = 0; i < n; i++) 
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write("*");
                Console.Write(new string('.', 3 * n + 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('.', n - 1 - i));
            }
            //mid
            Console.WriteLine(new string('*', 5 * n));
            //bottom
            for (int i = 0; i <= 2 * n; i++)
            {
                Console.Write(new string('.', i + 1));
                Console.Write("*");
                Console.Write(new string('.', 4 * n - 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('.', i + 1));
            }
        }
    }
}
