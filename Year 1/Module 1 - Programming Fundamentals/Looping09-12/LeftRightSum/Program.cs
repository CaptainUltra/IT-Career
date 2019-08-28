using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumL = 0, sumR = 0;
            for(int i = 0; i<n; i++)
            {
                sumL += double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sumR += double.Parse(Console.ReadLine());
            }
            if (sumL == sumR)
            { Console.WriteLine("Yes, sum = " + sumL); }
            else
            {
                Console.WriteLine("No, diff = " +
                            Math.Abs(sumR - sumL));
            }

        }
    }
}
