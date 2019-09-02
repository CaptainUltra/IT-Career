using System;

namespace EvenOddMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            var result = GetMultipleOfOddEvenDigits(num);
            System.Console.WriteLine(result);
        }

        private static long GetMultipleOfOddEvenDigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum*evenSum;
        }

        private static SumOddDigits(int num)
        {
            long sum = 0;
            while(num > 0)
            {
                var digit = num%10;
                if(digit %2 != 0)
                    sum += digit;
                num /= 10;
            }
        }

        private static object SumEvenDigits(int num)
        {
            long sum = 0;
            while(num > 0)
            {
                var digit = num%10;
                if(digit %2 == 0)
                    sum += digit;
                num /= 10;
            }
        }
    }
}
