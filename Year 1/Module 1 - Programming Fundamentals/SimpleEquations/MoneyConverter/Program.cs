using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            string v1 = Console.ReadLine();
            string v2 = Console.ReadLine();
            double a=0;//suma v leva
            switch(v1)
            {
                case "USD": a = 1.79549 * m; break;
                case "BGN": a = m; break;
                case "GBP": a = 2.53405 * m; break;
                case "EUR": a = 1.95583 * m; break;
            }
            switch(v2)
            {
                case "BGN": Console.WriteLine(a); break;
                case "GBP": Console.WriteLine(Math.Round(a / 2.53405, 2)); break;
                case "EUR": Console.WriteLine(Math.Round(a / 1.95583, 2)); break;
                case "USD": Console.WriteLine(Math.Round(a / 1.79549, 2)); break;
            }
        }
    }
}
