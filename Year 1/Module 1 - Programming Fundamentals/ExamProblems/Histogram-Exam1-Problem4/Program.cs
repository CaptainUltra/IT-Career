using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_Exam1_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double br1 = 0, br2 = 0, br3 = 0, br4 = 0, br5 = 0;
            for(int i =0;i <n;i++)
            {
                var a = double.Parse(Console.ReadLine());
                if (a < 200) br1++;
                else if (a <= 399) br2++;
                    else if (a <= 599) br3++;
                        else if (a <= 799) br4++;
                            else br5++;
            }
            double p1 = br1 / n * 100;
            double p2 = br2 / n * 100;
            double p3 = br3 / n * 100;
            double p4 = br4 / n * 100;
            double p5 = br5 / n * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
