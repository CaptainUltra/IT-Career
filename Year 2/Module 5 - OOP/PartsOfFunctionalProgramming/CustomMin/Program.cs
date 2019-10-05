using System;
using System.Linq;

namespace CustomMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();
            var min = numbers.OrderBy(x => x).First();
            System.Console.WriteLine(min);
        }
    }
}
