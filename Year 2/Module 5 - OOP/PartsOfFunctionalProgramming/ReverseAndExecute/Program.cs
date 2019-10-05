using System;
using System.Linq;

namespace ReverseAndExecute
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            int n = int.Parse(Console.ReadLine());
            numbers = numbers.Reverse().ToArray();
            numbers = numbers.Where(x => x % n != 0).ToArray();
            System.Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
