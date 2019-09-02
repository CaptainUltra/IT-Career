using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var pom = a;
            System.Console.WriteLine("Before:");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");
            a=b;
            b=pom;
            System.Console.WriteLine("After:");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");
        }
    }
}
