using System;
using System.Linq;

namespace GetMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n =items.Length;
            if(n==1)
            {
                System.Console.WriteLine("{1}",String.Join(' ', items));
            }
            else if(n % 2==0)
            {
                System.Console.WriteLine($"{items[n/2-1]}, {items[n/2]}");
            }
            else
            {
                System.Console.WriteLine($"{items[n/2-1]}, {items[n/2]}, {items[n/2+1]}");
            }
        }
    }
}
