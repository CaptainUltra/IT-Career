using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonbonki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, m = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            bool flag = true;
            while (flag==true)
            {
                if (a==0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    a--;
                    m++;
                }
                if (b == 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    b--;
                    m++;
                }
                if (c == 0)
                {
                    flag = false;
                }
                else
                {
                    c--;
                    m++;
                }
            }
            Console.WriteLine(m);
        }
    }
}
