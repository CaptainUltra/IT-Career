using System;

namespace PrintRhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n;i++)
            {
                PrintSpaces(n-i);
                PrintLineLeft(i, 1);
                PrintLineRight(2, i);
                System.Console.WriteLine();
            }
            for(int i = n-1;i>=1;i--)
            {
                PrintSpaces(n-i);
                PrintLineLeft(i, 1);
                PrintLineRight(2, i);
                System.Console.WriteLine();
            }
        }

        static void PrintLineLeft(int start, int end)
        {
            for(int i = start; i>= end; i--)
            {
                Console.Write(i);
            }
        }

        static void PrintLineRight(int start, int end)
        {
            for(int i = start; i<= end; i++)
            {
                Console.Write(i);
            }
        }

        static void PrintSpaces(int count)
        {
                Console.Write(new string(' ', count));
        }
    }
}
