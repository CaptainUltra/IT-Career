using System;
using System.Linq;

namespace ReverseArrayRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Count()-1;
            ReversePrint(arr, n);
        }
        private static void ReversePrint(int[] arr, int n)
        {
            if(n == 0)
            {
                System.Console.WriteLine(arr[0]);
                return;
            }
            System.Console.WriteLine(arr[n]);
            ReversePrint(arr, n-1);
        }

    }
}
