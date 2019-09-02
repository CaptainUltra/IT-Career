using System;
using System.Linq;

namespace DecimalToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = "";
            while(input[1] > 0)
            {
                result = (input[1]%input[0]).ToString() + result;
                input[1] = input[1]/input[0];
            }
            System.Console.WriteLine(result);
        }
    }
}
