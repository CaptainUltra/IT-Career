using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
            //2ri nachin. S vlojeni cikli
            /*var n = int.Parse(Console.ReadLine());
            for (var r = 1; r <= n; r++)
            {
                Console.Write("*");
                for (var c = 1; c < n; c++) Console.Write(" *");
                Console.WriteLine();
            }*/
        }
    }
}
