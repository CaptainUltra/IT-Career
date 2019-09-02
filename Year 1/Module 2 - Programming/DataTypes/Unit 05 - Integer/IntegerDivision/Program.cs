using System;

namespace IntegerDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            var a, b;
            int sum =0;
            for(int i = 0; i<=n-1;i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                sum += a%b;
            }
            System.Console.WriteLine(sum);
        }
    }
}
