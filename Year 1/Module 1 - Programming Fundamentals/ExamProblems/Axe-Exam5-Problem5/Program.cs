using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe_Exam5_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n ; i++) 
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('-', n*3-2-i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', n * 3 + 1));
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));
            }
            for (int i = n; i > 0; i--) 
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                if(n-i<n/2)
                {
                    Console.Write("*");
                }
                else Console.WriteLine(new string('-', n-i-1));
                Console.Write("*");
            }
        }
    }
}
