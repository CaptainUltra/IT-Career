using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSumMultiplication
{
    class Program
    {
        static int GetMultipleOfEvensAndOdds(int a, int b)
        {
            int mult = a * b;
            return mult;
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int ed = num % 10;
                if (ed % 2 == 0) sum += ed;
                num /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int ed = num % 10;
                if (ed % 2 != 0) sum += ed;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(GetSumOfEvenDigits(Math.Abs(a)), GetSumOfOddDigits(Math.Abs(a))));
        }
    }
}
