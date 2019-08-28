using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            if (dist < 20)
            {
                if (time == "day") Console.WriteLine(0.7 + dist * 0.79);
                else Console.WriteLine(0.7 + dist * 0.9);
            }
            else if (dist < 100) Console.WriteLine(dist * 0.09);
            else Console.WriteLine(dist * 0.06);
        }
    }
}
