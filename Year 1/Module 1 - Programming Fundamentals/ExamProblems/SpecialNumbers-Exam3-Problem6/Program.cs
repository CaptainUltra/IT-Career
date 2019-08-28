using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers_Exam3_Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=9;i++)
                for(int j = 1; j<=9;j++)
                    for(int k =1; k<=9;k++)
                        for(int p=1;p<=9;p++)
                        {
                            if (i <= n && j <= n && k <= n && p <= n)
                            {
                                if (n % i == 0 && n % j == 0 && n % k == 0 && n % p == 0)
                                {
                                    Console.Write(i);
                                    Console.Write(j);
                                    Console.Write(k);
                                    Console.Write(p);
                                    Console.Write(" ");
                                }
                            }
                        }
        }
    }
}
