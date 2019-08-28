using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Exam4_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var btc = double.Parse(Console.ReadLine());
            var cny = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());
            var lev = btc * 1168 + (cny*0.15)*1.76;
            var euro = lev / 1.95;
            euro -= euro * commision / 100;
            Console.WriteLine(euro);
        }
    }
}
