using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort_Exam1_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carrets = new string('^', n / 2);
            var mid = new string ('_', n / 2);
            var internalSpace = new string(' ', (2 * n) - 2);
            //Top row
            Console.WriteLine($"/{carrets}\\{mid}/{carrets}\\");
            //Middle part
            for (int i =0; i<= n; i++)//redove
            {
                Console.Write("|");
                Console.Write(internalSpace);
                Console.WriteLine("|");
            }
            //Bottom row
            Console.WriteLine($"\\{mid}/{mid}\\{mid}/");
        }
    }
}
