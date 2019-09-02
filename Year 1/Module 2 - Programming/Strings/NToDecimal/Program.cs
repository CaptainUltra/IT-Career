using System;

namespace NToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] num = input[1].ToCharArray();
            int sys = int.Parse(input[0]);
            int step = 0;
            //string result = "";
            double result = 0;
            int i = num.Length-1;
            while(i>=0)
            {
                result = (num[i] - '0')*Math.Pow(sys, step) + result;
                i--;
                step++;
            }
            System.Console.WriteLine(result);
        }
    }
}
