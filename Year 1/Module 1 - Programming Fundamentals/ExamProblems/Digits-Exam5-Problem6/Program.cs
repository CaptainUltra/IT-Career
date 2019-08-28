using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Exam5_Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dig1 = n / 100;
            var dig2 = n / 10 % 10;
            var dig3 = n % 10;
            var rows = dig1 + dig2;
            var col = dig1 + dig3;
            for (int i=0;i<=rows-1;i++)
            {
                for(int j=0;j<=col-1;j++)
                {
                    if (n % 5 == 0) n -= dig1;
                    else if (n % 3 == 0) n -= dig2;
                    else n += dig3;
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
