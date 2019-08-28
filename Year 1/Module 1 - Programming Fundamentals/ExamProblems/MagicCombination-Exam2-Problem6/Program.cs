using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination_Exam2_Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for(int i = 1;i<=9;i++)
                for (int j = 1; j <= 9; j++)
                    for (int k = 1; k <= 9; k++)
                        for (int p = 1; p <= 9; p++)
                            for (int r = 1; r <= 9; r++)
                                for (int t = 1; t <= 9; t++)
                                {
                                    sum = i * j * k * p * r * t;
                                    if (sum == n)
                                    {
                                        Console.Write(i);
                                        Console.Write(j);
                                        Console.Write(k);
                                        Console.Write(p);
                                        Console.Write(r);
                                        Console.Write(t);
                                        Console.Write(" ");
                                    }
                                }
        }
    }
}
