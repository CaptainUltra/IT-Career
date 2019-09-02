using System;

namespace PrintSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine(new string('-', n*2));
            for(int i = 1;i<=n-2;i++)
            PrintMidRows(n);
            System.Console.WriteLine(new string('-', n*2));
        }

        private static void PrintMidRows(int n)
        {
            System.Console.Write('-');
            for(int i = 1; i<n;i++)
            {
                System.Console.Write("\\/");
            }
            System.Console.WriteLine('-');
        }
    }
}
