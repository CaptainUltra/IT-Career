using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = double.Parse(Console.ReadLine());
            sum += max;
            for (int i = 1; i<=n-1;i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a > max) max = a;
                sum += a;
            }
            if ((sum - max) == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (sum - max));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff =" + Math.Abs(max - (sum - max)));
            }
        }
    }
}
