using System;
using System.Linq;

namespace BalancedArr
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //System.Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length / 2; i++)
            {
                for (int j = 0; j < arr.Length/2 - i - 1; j++) 
                if (arr[j] > arr[j + 1]) 
                {
                    int temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                }
            }
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {
                for (int j = arr.Length / 2; j < arr.Length - 1 - i + arr.Length/2; j++) 
                if (arr[j] < arr[j + 1]) 
                {
                    int temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                }
            }
            System.Console.WriteLine(String.Join(" ", arr));
        }
    }
}
