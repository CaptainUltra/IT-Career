using System;
using System.Linq;

namespace Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        numbers = numbers.Select(x => x + 1).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(x => x * 2).ToArray();
                        break;
                    case "substract":
                        numbers = numbers.Select(x => x - 1).ToArray();
                        break;
                    case "print":
                        System.Console.WriteLine(String.Join(' ', numbers));
                        break;

                }
                input = Console.ReadLine();
            }
        }
    }
}
