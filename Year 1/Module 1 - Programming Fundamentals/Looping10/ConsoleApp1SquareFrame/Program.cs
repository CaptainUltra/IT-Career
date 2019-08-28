using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // Print the top row: + - - - +
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
            for (int row = 0; row < n - 2; row++)
            // TODO: print the mid rows: | - - - |
            for(int i = 0; i<n-2; i ++)
                {
                    Console.WriteLine("|");
                    for (int j = 0; j < n - 2; j++) Console.WriteLine("-");
                    Console.WriteLine("|");
                }
            // TODO: print the bottom row: + - - - +
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");

        }
    }
}
