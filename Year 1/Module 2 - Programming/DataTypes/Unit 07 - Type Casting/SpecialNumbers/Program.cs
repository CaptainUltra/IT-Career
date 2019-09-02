using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<=n-1; i++)
            {
                int k=i;
                int ed = 0;
                int sum = 0;
                while(k!=0)
                {
                    ed = k % 10;
                    k /= 10;
                    sum += ed;
                }
                if(sum==7||sum==11||sum==5) System.Console.WriteLine("{0} -> True", i);
                else System.Console.WriteLine("{0} -> False", i);
            }
        }
    }
}
