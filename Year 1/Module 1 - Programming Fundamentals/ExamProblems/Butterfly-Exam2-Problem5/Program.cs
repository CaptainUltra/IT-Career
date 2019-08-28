using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly_Exam2_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = new string('*', n - 2);
            var dashes = new string('-', n - 2);
            var spaces = new string(' ', n - 1);
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{stars}\\ /{stars}");
                }
                else
                {
                    Console.WriteLine($"{dashes}\\ /{dashes}");
                }
            }
            Console.WriteLine($"{spaces}@{spaces}");
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{stars}/ \\{stars}");
                }
                else
                {
                    Console.WriteLine($"{dashes}/ \\{dashes}");
                }
            }
        }
    }
}
