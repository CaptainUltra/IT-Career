using System;

namespace Presentation19
{
    class Program
    {
        static void PrintNumbers(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
            Console.Write("{0} ", i);
            }
        }
        static void Main(string[] args)
        {
            PrintNumbers(5, 10);
            PrintNumbers(15);
            PrintNumbers();
            PrintNumbers(end: 40, start: 35);
        }
    }
}
