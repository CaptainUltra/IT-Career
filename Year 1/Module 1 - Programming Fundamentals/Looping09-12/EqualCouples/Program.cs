using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualCouples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            double diff = 0;
            for(int i = 1; i<=n-1;i++)
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                if ((sum - (a + b)) == 0) diff = 0;
                else if(Math.Abs((sum - (a + b)))>diff)diff = sum - (a + b);
                sum = a + b;
            }
            if (diff == 0) Console.WriteLine("Yes, value=" + sum);
            else Console.WriteLine("No, maxdiff="+Math.Abs(diff));
        }
    }
}
