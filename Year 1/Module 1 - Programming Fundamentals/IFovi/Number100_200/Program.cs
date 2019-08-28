using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 100) Console.WriteLine("Less than 100");
            else if (a >= 100 && a <= 200) Console.WriteLine("Betweeen 100 and 200");
            else Console.WriteLine("Greater than 200");
        }
    }
}
