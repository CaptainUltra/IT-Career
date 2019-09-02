using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(i = items.Length;i>0;i--)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}
